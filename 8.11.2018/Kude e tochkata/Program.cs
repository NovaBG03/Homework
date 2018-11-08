using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kude_e_tochkata
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x, y1, y2, y;

            do
            {
                Console.WriteLine("Vuvedete usporednika");
                Console.WriteLine("Vuvedete gornata lqva tochka");
                Console.Write("x1 = ");
                x1 = double.Parse(Console.ReadLine());
                Console.Write("y1 = ");
                y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedete dolnata dqsna tochka");
                Console.Write("x2 = ");
                x2 = double.Parse(Console.ReadLine());
                Console.Write("y2 = ");
                y2 = double.Parse(Console.ReadLine());
            } while (x1 > x2 || y1 < y2);

            Console.WriteLine("Vuvedete tochka, za koqto shte se izvurshva proverka");
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());

            bool inside = x1 < x && x < x2 && y1 > y && y > y2;
            bool outside = x1 > x || x > x2 || y1 < y || y < y2;

            if(inside)
            {
                Console.WriteLine("Tochkata e v pravougalnika");
            }
            else if (outside)
            {
                Console.WriteLine("Tochkata e izvun pravougalnika");
            }
            else
            {
                Console.WriteLine("Tochkata e vurhu strana ot pravougulnika");
            }

            Console.ReadLine();
        }
    }
}
