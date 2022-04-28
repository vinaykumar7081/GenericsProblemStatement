using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class MaxNumber
    {
        public int FindMaxInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is Greater");
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is Greater");
                return second;
            }
            else 
            {
                Console.Write("Greatest Number is third:->");
            return third;
            }
        }
    }
}
