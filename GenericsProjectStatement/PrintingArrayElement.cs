using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProjectStatement
{
    public class PrintingArrayElement
    {
        public void Maximumelement<T>(T[] ArrayElement)
        {
            foreach (T element in ArrayElement)
            { 
            Console.Write(element+" ");
            }
            Console.WriteLine(" ");
            Array.Sort(ArrayElement);
            int lent=ArrayElement.Length;
            Console.WriteLine("Greatest Element is:->" + ArrayElement[lent - 1]);
        }
    }
}
