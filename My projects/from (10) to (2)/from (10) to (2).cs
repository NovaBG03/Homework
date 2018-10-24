using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number10 = int.Parse(Console.ReadLine());
            int number2 = 0;
            int io = 1;
            while (number10 != 0)
            {
                number2 = number2 + ((number10 % 2) * io);
                number10 = number10 / 2;
                io = io * 10;
            }
            Console.WriteLine(number2);
            Console.ReadLine();
        }
    }
}
