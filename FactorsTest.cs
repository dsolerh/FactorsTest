using System;
using Xunit;
using FactorsLib;

namespace FactorsTest
{
    public class FactorsTest
    {
        [Fact]
        public void TestIsPrime()
        {
            // arrange
            int[] x = { 1, 2, 10, 37, 81 };
            bool[] expected = { true, true, false, true, false };

            // act
            bool[] result = new bool[5];
            for (int i = 0; i < 5; i++)
            {
                result[i] = Factors.IsPrime(x[i]);
            }

            // assert
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}
