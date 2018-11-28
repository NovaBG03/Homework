using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamichen_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> negativeNumbers = new List<int>();
            bool negative = false;

            for (int i = 0; i < numbers.Count(); i++)
            {
                if ( numbers[i] < 0 && numbers[i] % 2 == 0)
                {
                    negativeNumbers.Add(numbers[i]);
                    negative = true;
                }
            }

            if (negative)
            {
                Console.WriteLine(Math.Round((double)negativeNumbers.Average() , 2));
            }
            else
            {
                Console.WriteLine("There are no negative even numbers");
            }
            
            Console.ReadLine();
        }
    }
}
