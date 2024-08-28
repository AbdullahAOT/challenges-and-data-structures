using Xunit;
using System.Runtime.CompilerServices;
using StackQueue;
namespace StackAndQueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void StackPushTest()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            Assert.Equal(2, stack.Peek().value);
        }
        [Fact]
        public void StackPopTest()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            Assert.Equal(1, stack.Peek().value);
        }
        [Fact]
        public void StackEmptyTest()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Pop();
            Assert.Equal(true, stack.IsEmpty());
        }
        [Fact]
        public void QueueEnqueueTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.Equal(1, queue.Peek().value);
        }
        [Fact]
        public void QueueDequeueTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            Assert.Equal(2, queue.Peek().value);
        }
        [Fact]
        public void QueueEmptyTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Dequeue();
            Assert.Equal(true, queue.IsEmpty());
        }
        [Fact]
        public void DeleteMiddle_OddNumberOfElements_RemovesMiddleElement()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            stack.DeleteMiddle();

            Assert.Equal(4, stack.length);
            Assert.Equal(5, stack.Peek().value);
        }

        [Fact]
        public void DeleteMiddle_EvenNumberOfElements_RemovesLowerMiddleElement()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);

            stack.DeleteMiddle();

            Assert.Equal(3, stack.length);
            Assert.Equal(8, stack.Peek().value);
        }

        [Fact]
        public void DeleteMiddle_OneElement_RemovesElement()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);

            stack.DeleteMiddle();

            Assert.Equal(0, stack.length);
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void DeleteMiddle_EmptyStack_ThrowsException()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();

            Assert.Throws<Exception>(() => stack.DeleteMiddle());
        }
        [Fact]
        public void TestPushAndGetMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(10);
            minStack.Push(5);
            minStack.Push(20);
            Assert.Equal(5, minStack.GetMin());

            minStack.Push(3);
            Assert.Equal(3, minStack.GetMin());
        }

        [Fact]
        public void TestPopAndGetMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(10);
            minStack.Push(5);
            minStack.Push(20);
            minStack.Push(3);
            Assert.Equal(3, minStack.GetMin());

            minStack.Pop();
            Assert.Equal(5, minStack.GetMin());
        }

        [Fact]
        public void TestTopAndIsEmpty()
        {
            MinStack minStack = new MinStack();
            Assert.True(minStack.IsEmpty());

            minStack.Push(10);
            Assert.False(minStack.IsEmpty());
            Assert.Equal(10, minStack.Top());

            minStack.Push(5);
            Assert.Equal(5, minStack.Top());
        }
    }
}