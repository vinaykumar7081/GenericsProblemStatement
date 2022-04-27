using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProjectStatement
{
    public class PrintingArrayElement
    {
        public void Maximumelement(float[] floatArray)
        {
            Array.Sort(floatArray);
            foreach (var str in floatArray)
            {
                Console.Write( str+" ");
            }
            Console.WriteLine(" ");
            int len= floatArray.Length;
            Console.WriteLine("Maximum Element of the Array is:->"+ floatArray[len-1]);
        }
    }
}
