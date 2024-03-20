using System.Xml.Linq;

namespace Task1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = head;
            action(node.Data);
            do
            {
                node = node.Next;
                action(node.Data);
            } while (node != tail);
        }
    }

    public class TestDemo
    {
        public static void Main()
        {
            Random random = new Random();
            GenericList<int> list = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(random.Next(-100, 100));
            }

            list.ForEach(n =>
            {
                Console.Write(n + " ");
            });
            Console.WriteLine();

            int max = int.MinValue;
            list.ForEach(n =>
            {
                max = Math.Max(max, n);
            });
            Console.WriteLine("Maxinum: " + max);

            int min = int.MaxValue;
            list.ForEach(n =>
            {
                min = Math.Min(min, n);
            });
            Console.WriteLine("Mininum: " + min);

            int sum = 0;
            list.ForEach(n =>
            {
                sum += n;
            });
            Console.WriteLine("Sum: " + sum);
        }
    }
}