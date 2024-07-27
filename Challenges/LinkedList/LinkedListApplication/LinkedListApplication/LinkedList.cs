﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApplication
{
    public class LinkedList
    {
        public Node head;
        public Node tail;
        public int length;
        public LinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }
        public void AddToLinkedList(int number)
        {
            if (head == null)
            {
                head = new Node();
                head.value = number;
                head.next = null;
                head.previous = null;
                tail = head;
                length++;
            }
            else
            {
                Node node = new Node();
                node.value = number;
                node.previous = tail;
                node.next = null;
                tail.next = node;
                tail = node;
                length++;
            }
        }
        public void PrintLinkedList()
        {
            Node node = this.head;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }
        public void LinkedListIncludes(int number)
        {
            bool exist = false;
            Node node = this.head;
            for (int i = 0; i < length; i++)
            {
                if (node.value == number)
                {
                    exist = true;
                    break;
                }
                node = node.next;
            }
            if (exist == true)
            {
                Console.WriteLine($"The number {number} does exist in the Linked List");
            }
            else
            {
                Console.WriteLine($"The number {number} does not exist in the Linked List");
            }
        }
        public void LinkedListRemove(int number)
        {
            bool exist = false;
            Node node = this.head;
            for (int i = 0; i < length; i++)
            {
                if (node.value == number)
                {
                    exist = true;
                    break;
                }
                node = node.next;
            }
            if (exist == true)
            {
                if (node == this.head)
                {
                    node.next.previous = null;
                    head = node.next;
                    node.next = null;
                }
                else if (node == this.tail)
                {
                    node.previous.next = null;
                    tail = node.previous;
                    node.previous = null;
                }
                else
                {
                    node.previous.next = node.next;
                    node.next.previous = node.previous;
                    node.next = null;
                    node.previous = null;
                }
                Console.WriteLine($"Number {number} has been removed from the Linked List");
                length--;
            }
            else
            {
                Console.WriteLine($"Number {number} does not exist in the Linked List");
            }
        }

        public void RemoveDuplicates()
        {
            if (head == null) return;

            HashSet<int> seenValues = new HashSet<int>();
            Node current = head;
            Node prev = null;

            while (current != null)
            {
                if (seenValues.Contains(current.value))
                {
                    prev.next = current.next;
                    if (current.next != null)
                    {
                        current.next.previous = prev;
                    }
                    else
                    {
                        tail = prev;
                    }
                    length--;
                }
                else
                {
                    seenValues.Add(current.value);
                    prev = current;
                }
                current = current.next;
            }
        }
    }
}