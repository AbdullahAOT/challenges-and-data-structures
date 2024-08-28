using System;

namespace StackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            Console.WriteLine(StackToString(stack)); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
            stack.DeleteMiddle();
            Console.WriteLine(StackToString(stack)); // Stack: Top -> 5 -> 8 -> 14 -> 7

            stack.Push(2);
            stack.Push(9);
            stack.Push(11);
            Console.WriteLine(StackToString(stack)); // Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
            stack.DeleteMiddle();
            Console.WriteLine(StackToString(stack)); // Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7
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
