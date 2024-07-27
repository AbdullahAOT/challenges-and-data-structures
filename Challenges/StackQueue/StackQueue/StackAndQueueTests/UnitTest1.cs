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
    }
}