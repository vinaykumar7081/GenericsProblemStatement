using FindMaximum;
using NUnit.Framework;


namespace TestMaximums
{
    public class Tests
    {
        [Test]
        public void GivenStringInput_WhenTestMax_FirstPosition_ShouldReturnMaxNum()
        {
            MaxString max =new MaxString();
            string actual = max.FindMaxString("Banana", "Peach", "Apple");
            Assert.AreEqual(actual, "Banana");
        }
       
    }
}