using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksPractice
{
    internal class SearchLargestNumberArray
    {
        int[] numbers = new int[] { 2, 4, 12, 34, 8, 15 };

        public void SearchLargestNumber()
        {
            int maxValueFromSort = numbers.OrderByDescending(x => x).First();

            int maxValueMax = numbers.Max<int>();

            Console.WriteLine("From Sort: " + maxValueFromSort);
            Console.WriteLine("From Max: " + maxValueMax);
        }
    }
}
