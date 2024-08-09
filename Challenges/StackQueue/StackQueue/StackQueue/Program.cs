namespace StackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //Console.WriteLine(stack.Peek().value);
            //Console.WriteLine("///////////////////////////////////////");
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //Console.WriteLine(queue.Peek().value);
            //Console.WriteLine("///////////////////////////////////////");
            Stack stack2 = new Stack();
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(4);
            stack2.Push(5);

            Console.WriteLine(StackToString(stack2)); 
            ReverseStack(stack2);
            Console.WriteLine(StackToString(stack2));
        }
        static void ReverseStack(Stack stack)
        {
            Queue tempQueue = new Queue();
            while (!stack.IsEmpty())
            {
                tempQueue.Enqueue(stack.Pop().value);
            }
            while (!tempQueue.IsEmpty())
            {
                stack.Push(tempQueue.Dequeue().value);
            }
        }
        static string StackToString(Stack stack)
        {
            Node current = stack.tail;
            string stackRepresentation = "Stack: Top -> ";

            while (current != null)
            {
                stackRepresentation += current.value + " -> ";
                current = current.previous;
            }

            stackRepresentation += "null";
            return stackRepresentation;
        }
    }
}
