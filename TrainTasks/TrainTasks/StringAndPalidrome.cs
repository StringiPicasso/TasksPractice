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
    }
}
