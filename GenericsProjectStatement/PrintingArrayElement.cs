using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProjectStatement
{
    public class PrintingArrayElement
    {
        public void Maximumstring(string[] stringArray)
        {
            Array.Sort(stringArray,0,4);
            foreach (string str in stringArray)
            {
                Console.Write( str+" ");
            }
            Console.WriteLine(" ");
            int len=stringArray.Length;
            Console.WriteLine("Maximum Element of the Array is:->"+stringArray[len-1]);
        }
    }
}
