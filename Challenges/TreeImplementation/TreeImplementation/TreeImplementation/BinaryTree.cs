﻿using System;
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

        public List<int> LargestValueEachLevel()
        {
            List<int> largestValues = new List<int>();
            if (Root == null) return largestValues;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int max = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node node = queue.Dequeue();
                    if (node.Data > max)
                    {
                        max = node.Data;
                    }

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                largestValues.Add(max);
            }

            return largestValues;
        }

        public List<int> PrintRightView()
        {
            List<int> rightView = new List<int>();
            if (Root == null) return rightView;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                Node rightmostNode = null;

                for (int i = 0; i < levelSize; i++)
                {
                    Node node = queue.Dequeue();
                    rightmostNode = node;

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                // Add the rightmost node of the current level to the list
                rightView.Add(rightmostNode.Data);
            }

            return rightView;
        }

        public int FindMaxLevelNodes()
        {
            if (Root == null)
                throw new InvalidOperationException("Tree is empty.");

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            int maxLevel = 0;
            int maxNodes = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = currentLevel;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    Node node = queue.Dequeue();

                    if (node.Left != null)
                        queue.Enqueue(node.Left);

                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }

                currentLevel++;
            }

            return maxLevel;
        }

    }

}
