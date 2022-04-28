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
        public void GivenIntInput_WhenTestMax_ThirdPosition_ShouldReturnMaxNum()
        {
            MaxNumber max = new MaxNumber();
            int actual = max.FindMaxInteger(45, 55, 30);
            Assert.AreEqual(actual, 55);
        }
    }
}
