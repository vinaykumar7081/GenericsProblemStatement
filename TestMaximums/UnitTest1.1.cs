using FindMaximum;
using NUnit.Framework;


namespace TestMaximums
{
    public class Tests
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaxNum()
        {
            GenericMaximum<int> max = new GenericMaximum<int>(1, 5, 10);
            int actual = max.FindMaxElement();
            Assert.AreEqual(actual, 10);
        }
       
    }
}