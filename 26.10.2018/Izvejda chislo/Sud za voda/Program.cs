using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sud_za_voda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your collector is 255ml.");
            int counter = 0;
            int counter2 = 0;
            int cup;
            int collector = 0;
            do
            {
                cup = int.Parse(Console.ReadLine());
                if (cup <= (255 - collector))
                {
                    collector += cup;
                    counter++;
                }
                else
                {
                    Console.WriteLine("There is no enough space!");
                }
                counter2++;
            } while (collector != 255);
            Console.WriteLine("The collector is full!");
            Console.WriteLine("{0}/{1}", counter, counter2);
            Console.ReadLine();
        }
    }
}
