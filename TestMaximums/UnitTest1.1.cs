using FindMaximum;
using NUnit.Framework;


namespace TestMaximums
{
    public class Tests
    {
        [Test]
        public void GivenIntInput_WhenTestMax_FirstPosition_ShouldReturnMaxNum()
        {
            MaxNumber max =new MaxNumber();
            int actual = max.FindMaxInteger(50,45,30);
            Assert.AreEqual(actual,50);
        }
       
    }
}