namespace B.Test
{
    public class SleightOfHandTest
    {
        [Fact]
        public void Test1()
        {
            // �����������
            var k = 3;
            var array = new int[,]
            {
                {1, 2, 3, 1},
                {2, 0, 0, 2},
                {2, 0, 0, 2},
                {2, 0, 0, 2},
            };

            // ��������
            var actual = Program.SleightOfHand(k, array);

            // �����������
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Test2()
        {
            // �����������
            var k = 4;
            var array = new int[,]
            {
                {1, 1, 1, 1},
                {9, 9, 9, 9},
                {1, 1, 1, 1},
                {9, 9, 1, 1},
            };

            // ��������
            var actual = Program.SleightOfHand(k, array);

            // �����������
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Test3()
        {
            // �����������
            var k = 4;
            var array = new int[,]
            {
                {1, 1, 1, 1},
                {1, 1, 1, 1},
                {1, 1, 1, 1},
                {1, 1, 1, 1},
            };

            // ��������
            var actual = Program.SleightOfHand(k, array);

            // �����������
            Assert.Equal(0, actual);
        }
    }
}