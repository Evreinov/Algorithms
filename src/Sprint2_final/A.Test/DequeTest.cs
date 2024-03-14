using System.Runtime.InteropServices;

namespace A.Test
{
    public class DequeTest
    {
        [Theory]
        [InlineData(5)]
        [InlineData(3, 2, 4, 6, 7)]
        [InlineData(2, -3, 52, 324, 11, -234)]
        public void PushFrontTest(params int[] numbers)
        {
            // �����������
            var queue = new Deque<int>(numbers.Length);

            // ��������
            foreach (var number in numbers)
            {
                queue.PushFront(number);
            }

            // �����������
            foreach (var number in numbers.Reverse())
            {
                Assert.Equal(number, queue.PopFront());
            }
        }

        [Theory]
        [InlineData(5)]
        [InlineData(3, 2, 4, 6, 7)]
        [InlineData(2, -3, 52, 324, 11, -234)]
        public void PushBackTest(params int[] numbers)
        {
            // �����������
            var queue = new Deque<int>(numbers.Length);

            // ��������
            foreach (var number in numbers)
            {
                queue.PushBack(number);
            }

            // �����������
            foreach (var number in numbers.Reverse())
            {
                Assert.Equal(number, queue.PopBack());
            }
        }

        [Fact]
        public void Example1()
        {
            // �����������
            var queue = new Deque<int>(4);

            // ��������
            queue.PushFront(861);
            queue.PushFront(-819);

            // �����������
            Assert.Equal(861, queue.PopBack());
            Assert.Equal(-819, queue.PopBack());
        }

        [Fact]
        public void Example2()
        {
            // �����������
            var queue = new Deque<int>(10);

            // ��������
            queue.PushFront(-855);
            queue.PushFront(0);

            // �����������
            Assert.Equal(-855, queue.PopBack());
            Assert.Equal(0, queue.PopBack());

            // ��������
            queue.PushBack(844);

            // �����������
            Assert.Equal(844, queue.PopBack());
            
            // ��������
            queue.PushBack(823);
        }

        [Fact]
        public void Example3()
        {
            // �����������
            var queue = new Deque<int>(6);

            // ��������
            queue.PushFront(-201);
            queue.PushBack(959);
            queue.PushBack(102);
            queue.PushFront(20);

            // �����������
            Assert.Equal(20, queue.PopFront());
            Assert.Equal(102, queue.PopBack());
        }

        [Fact]
        public void PushFrontException()
        {
            // �����������
            var queue = new Deque<int>(0);

            // �����������
            Assert.Throws<InvalidOperationException>(() => queue.PushFront(-1));
        }

        [Fact]
        public void PushBackException()
        {
            // �����������
            var queue = new Deque<int>(2);

            // ��������
            queue.PushBack(24);
            queue.PushFront(21);

            // �����������
            Assert.Throws<InvalidOperationException>(() => queue.PushBack(-1));
        }

        [Fact]
        public void PopFrontException()
        {
            // �����������
            var queue = new Deque<int>(10);

            // ��������
            queue.PushBack(24);
            queue.PushFront(21);
            queue.PopBack();
            queue.PopFront();

            // �����������
            Assert.Throws<InvalidOperationException>(() => queue.PopFront());
        }

        [Fact]
        public void PopBackException()
        {
            // �����������
            var queue = new Deque<int>(2);

            // �����������
            Assert.Throws<InvalidOperationException>(() => queue.PopBack());
        }
    }
}
