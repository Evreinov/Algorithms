namespace A.Test
{
    public class NearestZeroTest
    {
        [Theory]
        [InlineData(5, new[] { 0, 1, 4, 9, 0 }, new[] { 0, 1, 2, 1, 0 })]
        [InlineData(6, new[] { 0, 7, 9, 4, 8, 20 }, new[] { 0, 1, 2, 3, 4, 5 })]
        [InlineData(1, new[] { 0 }, new[] { 0 })]
        [InlineData(1, new[] { 1 }, new[] { 1 })]
        public void Test(int n, int[] array, int[] expected)
        {
            // Действие
            var actual  = Program.NearestZero(n, array);

            // Утверждение
            Assert.Equal(expected, actual);
        }
    }
}