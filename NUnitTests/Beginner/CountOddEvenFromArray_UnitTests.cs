using ConsoleApp_DSABeginner.Beginner.CountOddEvenFromArray;

namespace NUnitTests.Beginner
{
    public class Tests
    {
        [TestCase(new uint[] { 2, 3, 4, 5, 6 }, true, (uint)2)]
        [TestCase(new uint[] { 2, 3, 4, 5, 6 }, false, (uint)3)]
        [TestCase(new uint[] { 22, 32, 42, 52, 62 }, true, (uint)0)]
        [TestCase(new uint[] { 22, 32, 42, 52, 62 }, false, (uint)5)]
        public void Test_OddEvenCount(uint[] inputArray, bool countOdd, uint expectedCount)
        {
            //Arrange
            CountOddEvenFromArray_Wrapper cWrapper = new(inputArray);

            //Act
            uint result = cWrapper.CalculateCount(countOdd);

            //Assert
            Assert.AreEqual(expectedCount, result);
        }
    }
}