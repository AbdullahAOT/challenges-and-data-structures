namespace StackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek().value);
            Console.WriteLine("///////////////////////////////////////");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.Peek().value);
        }
    }
}
