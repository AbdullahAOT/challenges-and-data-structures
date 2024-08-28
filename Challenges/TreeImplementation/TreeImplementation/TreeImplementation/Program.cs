using System;
using System.Collections.Generic;

namespace TreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree and Binary Search Tree Implementation\n");

            BinarySearchTree bst = new BinarySearchTree();

            Console.WriteLine("Adding nodes to BST:");
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(2);
            bst.Add(7);
            bst.Add(12);
            bst.Add(20);
            bst.Print(bst.Root);
            Console.WriteLine();

            int searchValue = 7;
            bool contains = bst.Contains(searchValue);
            Console.WriteLine($"Does BST contain {searchValue}? {contains}\n");

            int removeValue = 5;
            Console.WriteLine($"Removing {removeValue} from BST:");
            bst.Remove(removeValue);
            bst.Print(bst.Root);
            Console.WriteLine();

            contains = bst.Contains(removeValue);
            Console.WriteLine($"Does BST contain {removeValue} after removal? {contains}\n");

            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);
            binaryTree.Root.Left.Left = new Node(4);
            binaryTree.Root.Left.Right = new Node(5);
            binaryTree.Root.Right.Left = new Node(6);
            binaryTree.Root.Right.Right = new Node(7);

            Console.WriteLine("Binary Tree Traversals:");
            List<int> preOrderResult = binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine("Pre-Order: " + string.Join(", ", preOrderResult));

            List<int> inOrderResult = binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine("In-Order: " + string.Join(", ", inOrderResult));

            List<int> postOrderResult = binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine("Post-Order: " + string.Join(", ", postOrderResult));

            Console.WriteLine("\nBinary Tree Structure:");
            binaryTree.Print(binaryTree.Root);
        }
    }
}
