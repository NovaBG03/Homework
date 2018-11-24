using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duma_v_indeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] letters = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (letters[i] == alphabet[j])
                    {
                        Console.Write("{0} ",j + 1);
                        break;
                    }
                }
            }
            

            Console.ReadLine();
        }
    }
}
