using Xunit;

namespace FlattenArray.Tests
{
    public class NestedArraysTestData : TheoryData<object[], int[]>
    {
        public NestedArraysTestData()
        {
            var test1 = new object[]
            {
                new object[]
                {
                    1, 2, new object[] {3}
                },
                4
            };
            var expected1 = new[] {1, 2, 3, 4};
            Add(test1, expected1);

            var test2 = new object[]
            {
                new object[]
                {
                    1, 2, new object[] {3}
                },
                4,
                new object[] {5},
                new object[] {new object[] {new object[] {6}}}
            };
            var expected2 = new[] { 1, 2, 3, 4, 5, 6 };
            Add(test2, expected2);

            var test3 = new object[]
            {
                new object[]
                {
                    3, 2, new object[] {1}
                },
                new object[]
                {
                    new object[] {6}
                },
                new object[] {9},
                new object[] {new object[] {new object[] {8}}},
                7
            };
            var expected3 = new[] { 3,2,1,6,9,8,7 };
            Add(test3, expected3);
        }
    }
}