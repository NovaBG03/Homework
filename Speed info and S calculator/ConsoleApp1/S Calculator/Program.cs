using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("square, rectangle, triangle or circle");
            string shape = Console.ReadLine();
            double a;
            double b;
            double ha;
            switch (shape)
            {
                case "square":
                    Console.Write("a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine(a*a);
                    break;
                case "rectangle":
                    Console.Write("a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * b);
                    break;
                case "triangle":
                    Console.Write("a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("ha= ");
                    ha = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * ha / 2);
                    break;
                case "circle":
                    Console.Write("r = ");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round( r * r * 3.14 , 2));
                    break;
            }
            Console.ReadLine();
        }
    }
}
