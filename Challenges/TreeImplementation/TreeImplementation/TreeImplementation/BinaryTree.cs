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

        public int? FindSecondMax()
        {
            if (Root == null) throw new InvalidOperationException("Tree is empty");

            int? max = null;
            int? secondMax = null;

            void Traverse(Node node)
            {
                if (node == null) return;

                if (max == null || node.Data > max)
                {
                    secondMax = max;
                    max = node.Data;
                }
                else if (node.Data < max && (secondMax == null || node.Data > secondMax))
                {
                    secondMax = node.Data;
                }

                Traverse(node.Left);
                Traverse(node.Right);
            }

            Traverse(Root);

            if (secondMax == null)
                throw new InvalidOperationException("Tree has fewer than two unique values");

            return secondMax;
        }

        public int SumOfLeafNodes()
        {
            return SumOfLeafNodes(Root);
        }

        private int SumOfLeafNodes(Node node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return node.Data;

            return SumOfLeafNodes(node.Left) + SumOfLeafNodes(node.Right);
        }
    }
}
