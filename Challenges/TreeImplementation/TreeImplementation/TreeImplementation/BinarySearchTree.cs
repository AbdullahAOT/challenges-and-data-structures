using System;

namespace TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node current = Root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public bool Contains(int data)
        {
            Node current = Root;
            while (current != null)
            {
                if (data == current.Data)
                    return true;
                current = data < current.Data ? current.Left : current.Right;
            }
            return false;
        }

        public void Remove(int data)
        {
            Root = RemoveNode(Root, data);
        }

        private Node RemoveNode(Node root, int data)
        {
            if (root == null) return root;

            if (data < root.Data)
                root.Left = RemoveNode(root.Left, data);
            else if (data > root.Data)
                root.Right = RemoveNode(root.Right, data);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Data = MinValue(root.Right);
                root.Right = RemoveNode(root.Right, root.Data);
            }
            return root;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Data;
            while (node.Left != null)
            {
                minValue = node.Left.Data;
                node = node.Left;
            }
            return minValue;
        }
    }
}
