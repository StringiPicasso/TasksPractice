using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTasks
{
    internal class DublicateCheck
    {
        int[] numbers = { 1, 2, 3, 3, 5, 5, 4, 6, 5, 4, 7 };
        string[] stings = { "a", "s", "d", "d", "f", "g", "g" };

        public void CheckArray()
        {
            int[] checknum = numbers.Distinct().ToArray();
            string[] checkString = stings.Distinct().ToArray();
            ShowResult(checknum, checkString);
        }

        private void ShowResult(int[] checknum, string[] checkString)
        {
            foreach (var item in checknum)
            {
                Console.WriteLine("int: " + item);

            }

            foreach (var item in checkString)
            {
                Console.WriteLine("string: " + item);

            }
        }
    }
}
