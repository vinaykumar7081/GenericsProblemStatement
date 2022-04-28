using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class MaxString
    {
        public string FindMaxString(string firstString, string secondString, string thirdString)
        {
            int first_Length = firstString.Length;
            int second_Length = secondString.Length;
            int third_Length = thirdString.Length;
            if (first_Length.CompareTo(second_Length) > 0 && first_Length.CompareTo(third_Length) > 0)
            {
                Console.WriteLine("First Number is Greater");
                return firstString;
            }
            if (second_Length.CompareTo(first_Length) > 0 && second_Length.CompareTo(third_Length) > 0)
            {
                Console.WriteLine("Second Number is Greater");
                return secondString;
            }
            else 
            {
                Console.Write("Greatest Number is third:->");
            return thirdString;
            }
        }
    }
}
