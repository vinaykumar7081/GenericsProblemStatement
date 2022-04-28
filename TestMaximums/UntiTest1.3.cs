using FindMaximum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximums
{
    public class UntiTest1
    {
        public void GivenFloatInput_WhenTestMax_ThirdPosition_ShouldReturnMaxNum()
        {
            MaxString max = new MaxString();
            string actual = max.FindMaxString("Peach", "Apple", "Banana");
            Assert.AreEqual(actual, "Banana");
        }
    }
}
