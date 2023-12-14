using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksPractice
{
    internal class ReverseString
    {
        public void ReverseService()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            char[] inputToChars = input.ToCharArray();

            Console.Write("Answer One: " + ReverseString(inputToChars));

            string ReverseString(char[] chars)
            {
                Array.Reverse(chars);

                return new string(chars);
            }
        }
    }
}
