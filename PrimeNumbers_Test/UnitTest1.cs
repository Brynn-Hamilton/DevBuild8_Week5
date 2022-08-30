using Lab5_PrimeNumbers;

namespace PrimeNumbers_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(11, 31)]
        [InlineData(15, 47)]
        [InlineData(25, 97)]

        public void TestGetPrime1(int value, int expected)
        {
           int actual = PrimeNumbers.GetPrime(value);
            Assert.Equal(expected, actual);
        }
    }
}