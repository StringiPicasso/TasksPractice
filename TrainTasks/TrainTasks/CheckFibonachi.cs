using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTasks
{
    internal class CheckFibonachi
    {
        int prevNumber = 0;
        int nextNumber = 1;
        int sum = 0;

        string input = Console.ReadLine();

        public void CheckFib()
        {
            if (int.TryParse(input, out int value))
            {
                Console.WriteLine(IsFib(value) ? "True" : "False");
            }
        }

        private bool IsFib(int value)
        {
            while (sum < value)
            {
                sum = prevNumber + nextNumber;
                prevNumber = nextNumber;
                nextNumber = sum;

                if (sum == value)
                {
                    return true;
                }
                else if (sum > value)
                {
                    return false;
                }
            }

            return false;
        }
    }
}
