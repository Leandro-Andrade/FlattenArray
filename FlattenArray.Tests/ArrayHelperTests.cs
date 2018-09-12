using Xunit;

namespace FlattenArray.Tests
{
    public class ArrayHelperTests
    {
        [Theory]
        [ClassData(typeof(NestedArraysTestData))]
        public void PassingNestedMultidimensionalArraysOfInt_ReturnsFlatArrayOfInt(object[] nestedArray, int[] expectedArray)
        {
            var actualResult = nestedArray.ToFlat();

            Assert.Equal(expectedArray.Length, actualResult.Length);

            for (var idx = 0; idx < actualResult.Length; idx++)
                Assert.Equal(expectedArray[idx], actualResult[idx]);
        }
    }
}
