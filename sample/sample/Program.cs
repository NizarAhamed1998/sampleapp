using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add2num(10,20));
            Console.WriteLine(sub2num(20,10));

        }
        #region add_two_number
        public static int add2num(int a, int b)
        {
            return a + b;
        }

        #endregion
        #region Subtract_two_number
        public static int sub2num(int a, int b)
        {
            return a - b;
        }
        #endregion
    }
}
