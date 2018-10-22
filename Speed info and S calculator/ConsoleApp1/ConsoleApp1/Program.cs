using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = int.Parse(Console.ReadLine());
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if( speed <= 50 )
            {
                Console.WriteLine("average");
            }
            else if (speed <= 100)
            {
                Console.WriteLine("fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("super fast");
            }
            Console.ReadLine();
        }
    }
}
