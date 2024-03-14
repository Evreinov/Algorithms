namespace B.Test
{
    public class CalculateTest
    {
        [Theory]
        [InlineData("2 1 + 3 *", 9)]
        [InlineData("7 2 + 4 * 2 +", 38)]
        [InlineData("4 13 5 / +", 6)]
        [InlineData("2 5 - 4 /", -1)]
        [InlineData("-4 3 * 3 -5 - / -7 -1 - -8 -10 - + *", 8)]
        public void Calculate(string line, int expected_result)
        {
            // Организация
            var array = line.Split();

            // Действие
            var actual_result = Program.Calculate(array);

            // Утверждение
            Assert.Equal(expected_result, actual_result);
        }
    }
}