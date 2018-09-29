using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обиколка_и_лице_на_триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete ednata strana na triugulnik i visochinata kum neq");
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("ha = ");
            var ha = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete drugite dve strani");
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("P = "); Console.WriteLine(a + b + c);
            Console.Write("S = "); Console.WriteLine((a*ha)/2);
            Console.ReadLine();
        }
    }
}