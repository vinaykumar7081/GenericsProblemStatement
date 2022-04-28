using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMaximum;
using NUnit.Framework;

namespace TestMaximums
{
    public class UnitTest1
    {
        public void GivenStringInput_WhenTestMax_SecondPosition_ShouldReturnMaxNum()
        {
            MaxString max = new MaxString();
            string actual = max.FindMaxString("Peach", "Banana", "Apple");
            Assert.AreEqual(actual, "Banana");
        }
    }
}
