using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTasks
{
    internal class Factorial
    {
        int result = 1;

        string input = Console.ReadLine();

        public void ShowResut()
        {
            if (int.TryParse(input, out int value))
            {
                for (int i = 1; i <= value; i++)
                {
                    result *= i;
                }

                Console.WriteLine(result);
            }
        }
    }
}
