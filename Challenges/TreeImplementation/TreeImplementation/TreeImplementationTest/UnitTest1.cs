using Xunit;
using System.Runtime.CompilerServices;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class UnitTest1
    {
        [Fact]
        public void PreOrder_ShouldReturnCorrectOrder()
        {
            var tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);

            var result = tree.PreOrder(tree.Root);

            Assert.Equal(new List<int> { 1, 2, 3 }, result);
        }

        [Fact]
        public void InOrder_ShouldReturnCorrectOrder()
        {
            var tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);

            var result = tree.InOrder(tree.Root);

            Assert.Equal(new List<int> { 2, 1, 3 }, result);
        }

        [Fact]
        public void PostOrder_ShouldReturnCorrectOrder()
        {
            var tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);

            var result = tree.PostOrder(tree.Root);

            Assert.Equal(new List<int> { 2, 3, 1 }, result);
        }

        [Fact]
        public void Add_ShouldAddNodesCorrectly()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
        }

        [Fact]
        public void Remove_ShouldRemoveNodeCorrectly()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Remove(5);

            Assert.False(bst.Contains(5));
        }

        [Fact]
        public void Contains_ShouldReturnTrueIfExists()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);

            Assert.True(bst.Contains(5));
            Assert.False(bst.Contains(20));
        }
    }
}