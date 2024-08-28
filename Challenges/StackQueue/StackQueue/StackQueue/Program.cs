using System;

namespace StackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            //StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            //stack.Push(7);
            //stack.Push(14);
            //stack.Push(3);
            //stack.Push(8);
            //stack.Push(5);

            //Console.WriteLine(StackToString(stack)); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
            //stack.DeleteMiddle();
            //Console.WriteLine(StackToString(stack)); // Stack: Top -> 5 -> 8 -> 14 -> 7

            //stack.Push(2);
            //stack.Push(9);
            //stack.Push(11);
            //Console.WriteLine(StackToString(stack)); // Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
            //stack.DeleteMiddle();
            //Console.WriteLine(StackToString(stack)); // Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7
            MinStack minStack = new MinStack();

            minStack.Push(15);
            Console.WriteLine($"Pushed 15, Min: {minStack.GetMin()}");

            minStack.Push(7);
            Console.WriteLine($"Pushed 7, Min: {minStack.GetMin()}");

            minStack.Push(12);
            Console.WriteLine($"Pushed 12, Min: {minStack.GetMin()}");

            minStack.Push(3);
            Console.WriteLine($"Pushed 3, Min: {minStack.GetMin()}");

            Console.WriteLine("Stack after pushes:");
            minStack.PrintStack();

            Console.WriteLine($"Current Min: {minStack.GetMin()}");

            Console.WriteLine($"Popped: {minStack.Pop()}");
            Console.WriteLine($"Current Min after pop: {minStack.GetMin()}");

            Console.WriteLine($"Popped: {minStack.Pop()}");
            Console.WriteLine($"Current Min after pop: {minStack.GetMin()}");

            Console.WriteLine($"Top element: {minStack.Top()}");

            minStack.Push(2);
            Console.WriteLine($"Pushed 2, Min: {minStack.GetMin()}");

            Console.WriteLine("Stack after pushing 2:");
            minStack.PrintStack();

            Console.WriteLine($"Current Min: {minStack.GetMin()}");

            Console.WriteLine($"Is stack empty? {minStack.IsEmpty()}");

            while (!minStack.IsEmpty())
            {
                Console.WriteLine($"Popped: {minStack.Pop()}");
            }
            Console.WriteLine($"Is stack empty after popping all? {minStack.IsEmpty()}");
        }

        //static string StackToString(Stack stack)
        //{
        //    Node current = stack.tail;
        //    string stackRepresentation = "Stack: Top -> ";

        //    while (current != null)
        //    {
        //        stackRepresentation += current.value + " -> ";
        //        current = current.previous;
        //    }

        //    stackRepresentation += "null";
        //    return stackRepresentation;
        //}
    }
}
