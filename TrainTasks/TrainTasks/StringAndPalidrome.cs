using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTasks
{
    internal class StringAndPalidrome
    {
        public void CheckString()
        {
            string inputStrng = Console.ReadLine();

            CheckStringEquals(inputStrng);
            CheckStringSequenceEqual(inputStrng);
            CheckNumberEquals(inputStrng);
        }

        private void CheckStringEquals(string inputStrng)
        {
            string reverseString = new string(inputStrng.Reverse().ToArray());

            Console.WriteLine(inputStrng.Equals(reverseString) ? "True" : "False");
        }

        private void CheckStringSequenceEqual(string inputStrng)
        {
            bool result = Enumerable.SequenceEqual(inputStrng, inputStrng.Reverse());

            Console.WriteLine(result ? "True" : "False");
        }

        private void CheckNumberEquals(string inputStrng)
        {
           // int reminderForCheck;
            int.TryParse(inputStrng, out int enterNumber);
            int tempNumber = enterNumber;
            int reverseNumber = 0; 

            while (enterNumber > 0)
            {
               // reminderForCheck = enterNumber;
            reverseNumber = reverseNumber*10+ enterNumber%10;
                enterNumber /= 10;
            }

            Console.WriteLine(tempNumber.Equals(reverseNumber)?"True":"False");
        }
    }
}
