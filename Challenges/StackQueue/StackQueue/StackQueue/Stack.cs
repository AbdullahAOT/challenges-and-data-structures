using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Stack
    {
        public Node head {  get; set; }
        public Node tail { get; set; }
        public int length {  get; set; }
        public Stack()
        {
            head = null;
            tail = null;
            length = 0;
        }
        public void Push(int value)
        {
            if (IsEmpty())
            {
                Node node = new Node(value);
                head = node;
                head.next = null;
                head.previous = null;
                tail = head;
                length++;
            }
            else
            {
                Node node = new Node(value);
                node.next = null;
                node.previous = tail;
                tail.next = node;
                tail = node;
                length++;
            }
        }
        public Node Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }
            else if(length == 1)
            {
                Node node = head;
                head = null;
                tail = null;
                length--;
                return node;
            }
            else
            {
                Node node = tail;
                tail = tail.previous;
                tail.next = null;
                length--;
                return node;
            }
        }
        public Node Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                return tail;
            }
        }
        public bool IsEmpty()
        {
            return length == 0 ? true : false;
        }

    }
    public class StackWithDeleteMiddle : Stack
    {
        public void DeleteMiddle()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty. Nothing to delete.");
            }

            int middleIndex = length / 2;  
            Stack tempStack = new Stack();

            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(Pop().value);
            }

            Pop();

            while (!tempStack.IsEmpty())
            {
                Push(tempStack.Pop().value);
            }
        }
    }
    public class MinStack
    {
        private Stack<int> stack;
        private Stack<int> minStack;

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int value)
        {
            stack.Push(value);
            if (minStack.Count == 0 || value <= minStack.Peek())
            {
                minStack.Push(value);
            }
        }

        public int Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            int value = stack.Pop();
            if (value == minStack.Peek())
            {
                minStack.Pop();
            }
            return value;
        }

        public int Top()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return stack.Peek();
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return minStack.Peek();
        }

        public void PrintStack()
        {
            Console.Write("Stack: Top -> ");
            foreach (var item in stack)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }
    }
}
