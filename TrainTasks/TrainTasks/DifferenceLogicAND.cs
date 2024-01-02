using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTasks
{
    internal class DifferenceLogicAND
    {
        bool f()
        {
            Console.WriteLine("f called");
            return false;
        }

        bool g()
        {
            Console.WriteLine("g called");
            return false;
        }

        void ShowResult()
        {
            bool result = f() && g();
            Console.WriteLine();
            result = f() & g();
        }
    }
}
