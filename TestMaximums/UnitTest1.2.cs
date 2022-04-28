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
            GenericMaximum<float> max = new GenericMaximum<float>(10.5f, 11.5f, 12.5f);
            float actual = max.FindMaxElement();
            Assert.AreEqual(actual, 12.5f);
        }
    }
}
