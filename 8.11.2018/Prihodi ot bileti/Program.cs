using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prihodi_ot_bileti
{
    class Program
    {
        static void Main(string[] args)
        {
            int ColumnNumber = int.Parse(Console.ReadLine());
            int SeatsNumber = int.Parse(Console.ReadLine());
            string Type = Console.ReadLine().ToLower(); // premiere, normal, discount

            switch (Type)
            {
                case "premiere":
                    Console.WriteLine(Math.Round(12.00 * ColumnNumber * SeatsNumber, 2));break;
                case "normal":
                    Console.WriteLine(Math.Round(7.50 * ColumnNumber * SeatsNumber, 2)); break;
                case "discount":
                    Console.WriteLine(Math.Round(5.60 * ColumnNumber * SeatsNumber, 2)); break;
            }

            Console.ReadLine();
        }
    }
}
