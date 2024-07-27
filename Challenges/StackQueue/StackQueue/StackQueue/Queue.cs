using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Queue
    {
        public Node head { get; set; }
        public Node tail { get; set; }
        public int length { get; set; }
        public Queue()
        {
            head = null;
            tail = null;
            length = 0;
        }
        public void Enqueue(int value)
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
        public Node Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            else if (length == 1)
            {
                Node node = head;
                head = null;
                tail = null;
                length--;
                return node;
            }
            else
            {
                Node node = head;
                head = head.next;
                head.previous = null;
                length--;
                return node;
            }
        }
        public Node Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }
            else
            {
                return head;
            }
        }
        public bool IsEmpty()
        {
            return length == 0 ? true : false;
        }
    }
}
