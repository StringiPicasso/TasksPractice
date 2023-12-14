using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksPractice
{
    internal class SmalestAndBiggestPrimeNumber
    {
        int[] numbers = new int[] { 4, 8, 14, 20, 10, 7, 2, 5, 11, 16, 27 };

        int MaxNumber = 0;
        int MinNumber = 0;

        public void SearchNumbers()
        {
            foreach (var item in numbers)
            {
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (item / i <= 1)
                        {
                            if (MaxNumber <= item)
                            {
                                MaxNumber = item;
                            }
                            if (MinNumber >= item || MinNumber <= 0)
                            {
                                MinNumber = item;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Min " + MinNumber);
            Console.WriteLine("Max " + MaxNumber);
        }
    }
}
