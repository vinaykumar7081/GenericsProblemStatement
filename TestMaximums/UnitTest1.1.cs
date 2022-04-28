using FindMaximum;
using NUnit.Framework;


namespace TestMaximums
{
    public class Tests
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaxNum()
        {
            GenericMaximum<int> max = new GenericMaximum<int>();
            int actual = max.FindMaxElement(1,5,10);
            Assert.AreEqual(actual, 10);
        }
       
    }
}