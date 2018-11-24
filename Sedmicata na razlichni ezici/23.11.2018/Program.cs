using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._11._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            do
            {
                day = int.Parse(Console.ReadLine());
                if( day > 0 && day < 8 )
                {
                    day--;
                    break;
                }
                Console.WriteLine("Enter correct day number!");
            } while (true);
            string language = Console.ReadLine(); //en gr bg fr ru
            language = language.ToLower();

            string[] en = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] gr = { "Δευτέρα", "Τρίτη", "Τετάρτη", "Πέμπτη", "Παρασκευή", "Σάββατο", "Κυριακή" };
            string[] bg = { "Понеделник", "Вторник", "Сряда", "Четвъртък", "Петък", "Събота", "Неделя" };
            string[] fr = { "Le lundi", "Mardi", "Le mercredi", "Jeudi", "Vendredi", "Samedi", "Le dimanche" };
            string[] ru = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            switch (language)
            {
                case "en": Console.WriteLine(en[day]); break;
                case "gr": Console.WriteLine(gr[day]); break;
                case "bg": Console.WriteLine(bg[day]); break;
                case "fr": Console.WriteLine(fr[day]); break;
                case "ru": Console.WriteLine(ru[day]); break;
            }

            Console.ReadLine();
        }
    }
}
