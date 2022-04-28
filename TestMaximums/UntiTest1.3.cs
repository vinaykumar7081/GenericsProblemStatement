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
            MaxNumber max = new MaxNumber();
            float actual = max.FindMaxFloat(45.1f, 55.5f, 30.9f);
            Assert.AreEqual(actual, 55.5f);
        }
    }
}
