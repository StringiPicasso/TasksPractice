using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTasks
{
    internal class CheckIsPerfectNumber
    {
        public void CheckNumberForPerfect()
        {
            string inputString = Console.ReadLine();
            CheckIsPerfect(inputString);
        }

        private void CheckIsPerfect(string inputString)
        {
            int sumDelite = 1;

            int.TryParse(inputString, out int number);

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    sumDelite += i;
                }
            }

            Console.WriteLine(number.Equals(sumDelite) ? "True" : "False");
        }
    }
}
