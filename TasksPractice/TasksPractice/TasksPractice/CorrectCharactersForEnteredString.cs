using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksPractice
{
    internal class CorrectCharactersForEnteredString
    {
        string correctMessage = "HELLO";
        string inputString;

        public void GetString()
        {
            inputString = Console.ReadLine();

            if (int.TryParse(inputString, out int countInput))
            {
                if (countInput > 1 && countInput < 100)
                {
                    for (int i = 0; i < countInput; i++)
                    {
                        Console.WriteLine(CheckLetters());
                    }
                }
                else
                {
                    Console.WriteLine("Не число");
                }
            }

           
        }

        private bool CheckLetters()
        {
            inputString = Console.ReadLine();

            if (correctMessage.Length == inputString.Length)
            {
                return correctMessage.All(x => inputString.Contains(x));
            }

            return false;
        }
    }
        
}
