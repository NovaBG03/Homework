using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = a;
            if (b <= 100)
            {
                a = a + 5;
            }
            else
            {
                a = a + a*120/100;
                if(b > 1000)
                {
                    a = a * 10 / 100;
                }
            }
            if (b%2 == 0)
            {
                a = a + 1;
            }
            if (b%10 == 5)
            {
                a = a + 2;
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
