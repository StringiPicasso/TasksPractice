using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTasks
{
    internal class PrimeNumberCheck
    {
        public void CheckNumber()
        {
            string input;

            Console.Write("Простое ли число: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine(IsSimple(number) ? "Простое число" : "Не простое число");
            }
            else
            {
                Console.WriteLine("Введено не целое число!");
            }

            bool IsSimple(int number)
            {
                if (number <= 1) return false;

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
