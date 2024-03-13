namespace Task2
{
    interface Shape
    {
        public double getArea();
    }

    class Circle : Shape
    {
        private double r;
        private double s;

        public Circle(double r)
        {
            Console.WriteLine("Building a circle...");
            this.r = r;
            s = Math.PI * r * r;
        }

        public double getArea()
        {
            return s;
        }
    }

    class Rectangle : Shape
    {
        private double l, w;
        private double s;

        public Rectangle(double l, double w)
        {
            Console.WriteLine("Building a rectangle...");
            this.l = l;
            this.w = w;
            s = l * w;
        }

        public double getArea()
        {
            return s;
        }
    }

    class Factory
    {
        private static Factory INSTANCE = new Factory(); 
        private Factory() { }

        public static Factory getInstance()
        {
            return INSTANCE;
        }

        public Shape produce(int i)
        {
            switch (i)
            {
                case 0:
                    return new Circle(5.0);
                case 1:
                    return new Rectangle(3.0, 4.0);
                default:
                    throw new Exception("Shape Producing Fail!");
            }
        }
    }

    class TestDemo
    {
        static void Main()
        {
            double sum = 0.0;
            Factory f  = Factory.getInstance();
            List<Shape> shapes = new List<Shape>(10);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    shapes.Add(f.produce(new Random().Next(2)));
                    sum += shapes[i].getArea();
                }catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(sum);
        }
    }
}