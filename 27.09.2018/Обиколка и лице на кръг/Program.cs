using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обиколка_и_лице_на_кръг
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete radiusa");
            Console.Write("r = ");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("P = ");
            Console.WriteLine(2 * 3.14 * r);
            Console.Write("S = ");
            Console.WriteLine(3.14 * r * r);
            Console.ReadLine();
        }
    }
}
