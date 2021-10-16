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

        [Fact]
        public void TestPrimeFactors()
        {
            // arrange
            int[] x = { 1, 2, 10, 40, 50 };
            int[][] expected = {
                new[] {1},
                new[] {2},
                new[] {2,5},
                new[] {2,2,2,5},
                new[] {2,5,5}
             };

            // act
            int[][] result = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                result[i] = Factors.PrimeFactors(x[i]);
            }

            // assert
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}
