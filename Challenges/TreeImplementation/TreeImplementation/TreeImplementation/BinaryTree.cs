using System;
using System.Collections.Generic;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public List<int> PreOrder(Node node)
        {
            List<int> result = new List<int>();
            if (node != null)
            {
                result.Add(node.Data);
                result.AddRange(PreOrder(node.Left));
                result.AddRange(PreOrder(node.Right));
            }
            return result;
        }

        public List<int> InOrder(Node node)
        {
            List<int> result = new List<int>();
            if (node != null)
            {
                result.AddRange(InOrder(node.Left));
                result.Add(node.Data);
                result.AddRange(InOrder(node.Right));
            }
            return result;
        }

        public List<int> PostOrder(Node node)
        {
            List<int> result = new List<int>();
            if (node != null)
            {
                result.AddRange(PostOrder(node.Left));
                result.AddRange(PostOrder(node.Right));
                result.Add(node.Data);
            }
            return result;
        }

        public void Print(Node node, string indent = "", bool isLeft = true)
        {
            if (node != null)
            {
                Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.Data);
                Print(node.Left, indent + (isLeft ? "│   " : "    "), true);
                Print(node.Right, indent + (isLeft ? "│   " : "    "), false);
            }
        }

        public void MirrorTree(Node node)
        {
            if (node == null)
                return;

            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            MirrorTree(node.Left);
            MirrorTree(node.Right);
        }

        public List<int> InOrderTraversal(Node node)
        {
            return InOrder(node);
        }
    }
}
