using System;
using System.Collections.Generic;

namespace TreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(4);
            //Btree.Root.Left = new Node(8);
            //Btree.Root.Right = new Node(7);
            //Btree.Root.Left.Left = new Node(12);
            //Btree.Root.Left.Right = new Node(9);

            //Console.WriteLine("Original InOrder:");
            //List<int> originalInorder = Btree.InOrderTraversal(Btree.Root);
            //Console.WriteLine(string.Join(", ", originalInorder));

            //Btree.MirrorTree(Btree.Root);

            //Console.WriteLine("Mirrored InOrder:");
            //List<int> mirroredInorder = Btree.InOrderTraversal(Btree.Root);
            //Console.WriteLine(string.Join(", ", mirroredInorder));

            //BinaryTree tree = new BinaryTree();

            //tree.Root = new Node(10);
            //tree.Root.Left = new Node(5);
            //tree.Root.Right = new Node(20);
            //tree.Root.Left.Left = new Node(3);
            //tree.Root.Left.Right = new Node(7);
            //tree.Root.Right.Left = new Node(15);
            //tree.Root.Right.Right = new Node(25);

            //Console.WriteLine("Original Tree:");
            //tree.Print(tree.Root);

            //try
            //{
            //    int? secondMax = tree.FindSecondMax();
            //    Console.WriteLine($"\nThe second maximum value in the tree is: {secondMax}");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine($"\nError: {ex.Message}");
            //}


            //BinaryTree negativeTree = new BinaryTree();
            //negativeTree.Root = new Node(-10);
            //negativeTree.Root.Left = new Node(-20);
            //negativeTree.Root.Right = new Node(-5);

            //Console.WriteLine("\nNegative Tree:");
            //negativeTree.Print(negativeTree.Root);

            //try
            //{
            //    int? secondMaxNegative = negativeTree.FindSecondMax();
            //    Console.WriteLine($"\nThe second maximum value in the negative tree is: {secondMaxNegative}");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine($"\nError: {ex.Message}");
            //}

            //BinaryTree singleNodeTree = new BinaryTree();
            //singleNodeTree.Root = new Node(10);

            //Console.WriteLine("\nSingle Node Tree:");
            //singleNodeTree.Print(singleNodeTree.Root);

            //try
            //{
            //    int? secondMaxSingleNode = singleNodeTree.FindSecondMax();
            //    Console.WriteLine($"\nThe second maximum value in the single node tree is: {secondMaxSingleNode}");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine($"\nError: {ex.Message}");
            //}

            //Console.ReadLine();
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(9);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(12);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(17);
            Btree.Root.Right.Right = new Node(23);
            Btree.Root.Left.Left.Right = new Node(4);

            // Print the tree
            Btree.Print(Btree.Root);

            // Calculate and display the sum of leaf nodes
            int leafSum = Btree.SumOfLeafNodes();
            Console.WriteLine($"Sum of leaf nodes: {leafSum}");

            Console.ReadLine();
        }
    }
}
