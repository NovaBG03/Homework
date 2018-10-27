using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izvejda_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            for (int i = 0; i < number; i++)
            {
                int counter = 0;
                int n = i;
                while ( n != 0 )
                {
                    counter = counter + n % 10;
                    n = n / 10;
                }
                if (counter == 5 || counter == 7 || counter == 11)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
