using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class GenericMaximum<T> where T : IComparable<T>
    {
        public T firstValue, secondValue, thirdValue;
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        { 
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public T FindMaxElement()
        {
           
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("First Number is Greater");
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("Second Number is Greater");
                return secondValue;
            }
            else 
            {
                Console.Write("Greatest Number is third:->");
            return thirdValue;
            }
        }
    }
}
