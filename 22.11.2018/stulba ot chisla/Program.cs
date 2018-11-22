using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stulba_ot_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nCoppy = n;
            int number = 1;
            int line = 0;

            while ( n > 0 )
            {
                line++;
                for (int i = 1; i <= line; i++)
                {
                    Console.Write($"{number} ");
                    number++;
                    if (number > nCoppy) break;
                }
                Console.WriteLine();
                n -= line;
            }



            Console.ReadLine();
        }
    }
}
