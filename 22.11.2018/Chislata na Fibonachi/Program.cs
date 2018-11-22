using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chislata_na_Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;

            while (number1 < n || number2 < n)
            {
                if (number1 < n)
                {
                    Console.Write($"{number1} ");
                    number1 += number2;
                }

                if (number2 < n)
                {
                    Console.Write($"{number2} ");
                    number2 += number1;
                }
            }

            Console.ReadLine();
        }
    }
}
