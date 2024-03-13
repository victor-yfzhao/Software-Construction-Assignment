using System.Runtime.ConstrainedExecution;
using System.Transactions;

namespace Task1
{
    interface Shape
    {
        public double getArea();
        public bool isLegal();
    }

    class Circle : Shape
    {
        private double r;
        private double s;

        public Circle(double r)
        {
            this.r = r;
            s = Math.PI * r * r;
        }

        public double getArea()
        {
            return s;
        }

        //不太懂除了三角形其他类为啥要做合法判断。。。
        public bool isLegal()
        {
            return true;
        }
    }

    class Rectangle : Shape
    {
        private double l, w;
        private double s;

        public Rectangle(double l, double w)
        {
            this.l = l;
            this.w = w;
            s = l * w;
        }

        public double getArea()
        {
            return s;
        }

        //不太懂除了三角形其他类为啥要做合法判断。。。
        public bool isLegal()
        {
            return true;
        }
    }

    class Triangle : Shape
    {
        private double a, b, c;
        private double s;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (!isLegal())
            {
                throw new Exception("Illegal Triangle!");
            }
            else
            {
                double p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public double getArea()
        {
            return s;
        }

        public bool isLegal()
        {
            return ((a + b) > c) && ((a - b) < c);
        }
    }

    class TestDemo
    {
        static void Main()
        {
            Circle c = new Circle(5.0);
            Console.WriteLine(c.getArea());
            Rectangle r = new Rectangle(3.0, 4.0);
            Console.WriteLine(r.getArea());
            try
            {
                Triangle t1 = new Triangle(3.0, 4.0, 5.0);
                Console.WriteLine(t1.getArea());
                Triangle t2 = new Triangle(1.0, 2.0, 3.0);
                Console.WriteLine(t2.getArea());
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}