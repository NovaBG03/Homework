using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_na_merni_edinici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merni edinici: mm, cm, m, km, mi, inch, yard, ft");
            Console.Write("chislo: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("ot merna edinica: ");
            string am = Console.ReadLine();
            Console.Write("kum merna edinica: ");
            string bm = Console.ReadLine();
            if (am == "mm")
            {
                a = a / 100; //to m
                if (bm == "mm")
                {
                    a = a * 100;
                }
                if (bm == "cm")
                {
                    a = a * 10;
                }
                if (bm == "km")
                {
                    a = a / 1000;
                }
                if (bm == "mi")
                {
                    a = a * 0.000621371192;
                }
                if (bm == "inch")
                {
                    a = a * 39.3700787;
                }
                if (bm == "yard")
                {
                    a = a * 1.0936133;
                }
                if (bm == "ft")
                {
                    a = a * 3.2808399;
                }
            }
            if(am == "sm")
            {
                a = a / 10; //to m
                if (bm == "mm")
                {
                    a = a * 100;
                }
                if (bm == "cm")
                {
                    a = a * 10;
                }
                if (bm == "km")
                {
                    a = a / 1000;
                }
                if (bm == "mi")
                {
                    a = a * 0.000621371192;
                }
                if (bm == "inch")
                {
                    a = a * 39.3700787;
                }
                if (bm == "yard")
                {
                    a = a * 1.0936133;
                }
                if (bm == "ft")
                {
                    a = a * 3.2808399;
                }
            }
            if (am == "m")
            {
                if (bm == "mm")
                {
                    a = a * 100;
                }
                if (bm == "cm")
                {
                    a = a * 10;
                }
                if (bm == "km")
                {
                    a = a / 1000;
                }
                if (bm == "mi")
                {
                    a = a * 0.000621371192;
                }
                if (bm == "inch")
                {
                    a = a * 39.3700787;
                }
                if (bm == "yard")
                {
                    a = a * 1.0936133;
                }
                if (bm == "ft")
                {
                    a = a * 3.2808399;
                }
            }
            if (am == "km")
            {
                a = a * 1000; //to m
                if (bm == "mm")
                {
                    a = a * 100;
                }
                if (bm == "cm")
                {
                    a = a * 10;
                }
                if (bm == "km")
                {
                    a = a / 1000;
                }
                if (bm == "mi")
                {
                    a = a * 0.000621371192;
                }
                if (bm == "inch")
                {
                    a = a * 39.3700787;
                }
                if (bm == "yard")
                {
                    a = a * 1.0936133;
                }
                if (bm == "ft")
                {
                    a = a * 3.2808399;
                }
            }
            if (am == "mi")
            {
                a = a * 1609.344; //to m
                if (bm == "mm")
                {
                    a = a * 100;
                }
                if (bm == "cm")
                {
                    a = a * 10;
                }
                if (bm == "km")
                {
                    a = a / 1000;
                }
                if (bm == "mi")
                {
                    a = a * 0.000621371192;
                }
                if (bm == "inch")
                {
                    a = a * 39.3700787;
                }
                if (bm == "yard")
                {
                    a = a * 1.0936133;
                }
                if (bm == "ft")
                {
                    a = a * 3.2808399;
                }
            }
            if (am == "inch")
            {
                a = a * 0.0254; //to m
                if (bm == "mm")
                {
                    a = a * 100;
                }
                if (bm == "cm")
                {
                    a = a * 10;
                }
                if (bm == "km")
                {
                    a = a / 1000;
                }
                if (bm == "mi")
                {
                    a = a * 0.000621371192;
                }
                if (bm == "inch")
                {
                    a = a * 39.3700787;
                }
                if (bm == "yard")
                {
                    a = a * 1.0936133;
                }
                if (bm == "ft")
                {
                    a = a * 3.2808399;
                }
            }
            if (am == "yard")
            {
                a = a * 0.9144; //to m
                if (bm == "mm")
                {
                    a = a * 100;
                }
                if (bm == "cm")
                {
                    a = a * 10;
                }
                if (bm == "km")
                {
                    a = a / 1000;
                }
                if (bm == "mi")
                {
                    a = a * 0.000621371192;
                }
                if (bm == "inch")
                {
                    a = a * 39.3700787;
                }
                if (bm == "yard")
                {
                    a = a * 1.0936133;
                }
                if (bm == "ft")
                {
                    a = a * 3.2808399;
                }
            }
            if (am == "ft")
            {
                a = a * 0.3048; //to m
                if (bm == "mm")
                {
                    a = a * 100;
                }
                if (bm == "cm")
                {
                    a = a * 10;
                }
                if (bm == "km")
                {
                    a = a / 1000;
                }
                if (bm == "mi")
                {
                    a = a * 0.000621371192;
                }
                if (bm == "inch")
                {
                    a = a * 39.3700787;
                }
                if (bm == "yard")
                {
                    a = a * 1.0936133;
                }
                if (bm == "ft")
                {
                    a = a * 3.2808399;
                }
            }
            a = Math.Round(a, 3);
            Console.WriteLine(a + " " + bm);
            Console.ReadLine();
        }
    }
}
