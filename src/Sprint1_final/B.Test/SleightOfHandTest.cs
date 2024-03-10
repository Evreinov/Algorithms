namespace B.Test
{
    public class SleightOfHandTest
    {
        [Fact]
        public void Test1()
        {
            // Организация
            var k = 3;
            var array = new int[,]
            {
                {1, 2, 3, 1},
                {2, 0, 0, 2},
                {2, 0, 0, 2},
                {2, 0, 0, 2},
            };

            // Действие
            var actual = Program.SleightOfHand(k, array);

            // Утверждение
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Test2()
        {
            // Организация
            var k = 4;
            var array = new int[,]
            {
                {1, 1, 1, 1},
                {9, 9, 9, 9},
                {1, 1, 1, 1},
                {9, 9, 1, 1},
            };

            // Действие
            var actual = Program.SleightOfHand(k, array);

            // Утверждение
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Test3()
        {
            // Организация
            var k = 4;
            var array = new int[,]
            {
                {1, 1, 1, 1},
                {1, 1, 1, 1},
                {1, 1, 1, 1},
                {1, 1, 1, 1},
            };

            // Действие
            var actual = Program.SleightOfHand(k, array);

            // Утверждение
            Assert.Equal(0, actual);
        }
    }
}