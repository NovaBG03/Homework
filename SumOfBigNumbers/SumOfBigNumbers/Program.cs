using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            Console.WriteLine(Add(number1 , number2));

            Console.ReadLine();
        }

        public static string Add(string number1, string number2)
        {
            string newNumber = "";

            if (number1.Length < number2.Length)
            {
                string help = number1;
                number1 = number2;
                number2 = help;
            }

            number1 = ReverseString(number1); 
            number2 = ReverseString(number2); 

            int one = 0;

            for (int i = 0 ; i < number2.Length; i++)
            {
                int sum = (int)char.GetNumericValue(number1[i]) + (int)char.GetNumericValue(number2[i]) + one;
                if (sum > 9)
                {
                    newNumber += Convert.ToString(sum % 10);
                    one = 1;
                }
                else
                {
                    newNumber += Convert.ToString(sum);
                    one = 0;
                }
            }

            if (number1.Length != number2.Length)
            {
                for (int i = number2.Length; i < number1.Length; i++)
                {
                    int sum = (int)char.GetNumericValue(number1[i]) + one;
                    if (sum > 9)
                    {
                        newNumber += Convert.ToString(sum % 10);
                        one = 1;
                    }
                    else
                    {
                        newNumber += Convert.ToString(sum);
                        one = 0;
                    }
                }
            }

            if (one == 1)
            {
                newNumber += one;
            }

            return ReverseString(newNumber); 
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

