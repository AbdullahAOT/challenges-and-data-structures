using System;
using System.Collections.Generic;

namespace TreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(12);
            Btree.Root.Left.Right = new Node(9);

            Console.WriteLine("Original InOrder:");
            List<int> originalInorder = Btree.InOrderTraversal(Btree.Root);
            Console.WriteLine(string.Join(", ", originalInorder));

            Btree.MirrorTree(Btree.Root);

            Console.WriteLine("Mirrored InOrder:");
            List<int> mirroredInorder = Btree.InOrderTraversal(Btree.Root);
            Console.WriteLine(string.Join(", ", mirroredInorder));
        }
    }
}
