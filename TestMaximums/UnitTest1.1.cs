using FindMaximum;
using NUnit.Framework;


namespace TestMaximums
{
    public class Tests
    {
        [Test]
        public void GivenFloatInput_WhenTestMax_FirstPosition_ShouldReturnMaxNum()
        {
            MaxNumber max =new MaxNumber();
            float actual = max.FindMaxFloat(50.5f,45.6f,30.7f);
            Assert.AreEqual(actual,50.5f);
        }
       
    }
}