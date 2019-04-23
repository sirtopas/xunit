using Xunit;

namespace unit_testing
{
    // Theories are tests which are only true for a particular set of data.
    public class Theories
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}