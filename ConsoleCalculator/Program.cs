// See https://aka.ms/new-console-template for more information
using System;

namespace Assignment1
{
    class ConcoleCalculator
    {
        static void Main(string[] args)
        {
            int a, b, ans;
            char op;
            string str;

            //input
            Console.Write("Please input the first number: ");
            str = Console.ReadLine();
            a = Int32.Parse(str);
            Console.Write("Please input the operator: ");
            str = Console.ReadLine();
            op = Char.Parse(str);
            Console.Write("Please input the second number: ");
            str = Console.ReadLine();
            b = Int32.Parse(str);

            //calculate
            switch (op)
            {
                case '+':
                    ans = a + b;
                    break;
                case '-':
                    ans = a - b;
                    break;
                case '*': 
                    ans = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Invalid Input!!");
                        return;
                    }
                    ans = a / b;
                    break;
                default: 
                    Console.WriteLine("Invalid Input!!");
                    return;
            }
            Console.WriteLine("Answer: " +  ans);
        }
    }
}
