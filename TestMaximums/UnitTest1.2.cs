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
        public void GivenIntInput_WhenTestMax_SecondPosition_ShouldReturnMaxNum()
        {
            MaxNumber max = new MaxNumber();
            int actual = max.FindMaxInteger(45, 55, 30);
            Assert.AreEqual(actual, 55);
        }
    }
}
