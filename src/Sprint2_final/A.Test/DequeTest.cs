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
            // Организация
            var queue = new Deque<int>(numbers.Length);

            // Действие
            foreach (var number in numbers)
            {
                queue.PushFront(number);
            }

            // Утверждение
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
            // Организация
            var queue = new Deque<int>(numbers.Length);

            // Действие
            foreach (var number in numbers)
            {
                queue.PushBack(number);
            }

            // Утверждение
            foreach (var number in numbers.Reverse())
            {
                Assert.Equal(number, queue.PopBack());
            }
        }

        [Fact]
        public void Example1()
        {
            // Организация
            var queue = new Deque<int>(4);

            // Действие
            queue.PushFront(861);
            queue.PushFront(-819);

            // Утверждение
            Assert.Equal(861, queue.PopBack());
            Assert.Equal(-819, queue.PopBack());
        }

        [Fact]
        public void Example2()
        {
            // Организация
            var queue = new Deque<int>(10);

            // Действие
            queue.PushFront(-855);
            queue.PushFront(0);

            // Утверждение
            Assert.Equal(-855, queue.PopBack());
            Assert.Equal(0, queue.PopBack());

            // Действие
            queue.PushBack(844);

            // Утверждение
            Assert.Equal(844, queue.PopBack());
            
            // Действие
            queue.PushBack(823);
        }

        [Fact]
        public void Example3()
        {
            // Организация
            var queue = new Deque<int>(6);

            // Действие
            queue.PushFront(-201);
            queue.PushBack(959);
            queue.PushBack(102);
            queue.PushFront(20);

            // Утверждение
            Assert.Equal(20, queue.PopFront());
            Assert.Equal(102, queue.PopBack());
        }

        [Fact]
        public void PushFrontException()
        {
            // Организация
            var queue = new Deque<int>(0);

            // Утверждение
            Assert.Throws<InvalidOperationException>(() => queue.PushFront(-1));
        }

        [Fact]
        public void PushBackException()
        {
            // Организация
            var queue = new Deque<int>(2);

            // Действие
            queue.PushBack(24);
            queue.PushFront(21);

            // Утверждение
            Assert.Throws<InvalidOperationException>(() => queue.PushBack(-1));
        }

        [Fact]
        public void PopFrontException()
        {
            // Организация
            var queue = new Deque<int>(10);

            // Действие
            queue.PushBack(24);
            queue.PushFront(21);
            queue.PopBack();
            queue.PopFront();

            // Утверждение
            Assert.Throws<InvalidOperationException>(() => queue.PopFront());
        }

        [Fact]
        public void PopBackException()
        {
            // Организация
            var queue = new Deque<int>(2);

            // Утверждение
            Assert.Throws<InvalidOperationException>(() => queue.PopBack());
        }
    }
}
