using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kubche_ot_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int counter = 0;

                for (int j = i; j <= n; j++)
                {
                    Console.Write(j + " ");
                    counter++;
                }

                for (int j = n - 1; j >= counter; j--)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
