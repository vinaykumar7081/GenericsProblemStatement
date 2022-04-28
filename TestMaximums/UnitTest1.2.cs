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
            GenericMaximum<float> max = new GenericMaximum<float>();
            float[] array = { 10.5f, 11.5f, 12.5f,15.8f,18.28f };
            float actual = max.FindMaxElement(array);
            Assert.AreEqual(actual, 18.28f);
        }
    }
}
