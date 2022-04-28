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
        public void GivenFloatInput_WhenTestMax_SecondPosition_ShouldReturnMaxNum()
        {
            MaxNumber max = new MaxNumber();
            float actual = max.FindMaxFloat(45.8f, 55.2f, 30.3f);
            Assert.AreEqual(actual, 55.2);
        }
    }
}
