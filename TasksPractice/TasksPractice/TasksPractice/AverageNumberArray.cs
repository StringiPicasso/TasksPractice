using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksPractice
{
    internal class AverageNumberArray
    {
        Random random = new Random();
        int[] numbers = new int[6];
        int answer = 0;

        public void StartDefenseNumber()
        {
            CreateArray();
            GetAverageNumber();
        }

        private void CreateArray()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 1000);
            }
        }

        private void GetAverageNumber()
        {
            foreach (var item in numbers)
            {
                answer += item;
            }

            answer = answer / numbers.Length;

            Console.WriteLine(answer);
        }
    }
}
