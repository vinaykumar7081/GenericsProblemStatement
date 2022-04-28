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
            int[] array = { 1, 5, 6, 7, 8, 9, 10 };
            int actual = max.FindMaxElement(array);
            Assert.AreEqual(actual, 10);
        }
       
    }
}