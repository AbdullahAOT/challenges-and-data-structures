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

        [Fact]
        public void TestMirrorTree_WithMultipleNodes()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(4);
            tree.Root.Left = new Node(8);
            tree.Root.Right = new Node(7);
            tree.Root.Left.Left = new Node(12);
            tree.Root.Left.Right = new Node(9);

            List<int> expectedOriginalInOrder = new List<int> { 12, 8, 9, 4, 7 };
            List<int> expectedMirroredInOrder = new List<int> { 7, 4, 9, 8, 12 };

            // Act
            List<int> originalInOrder = tree.InOrderTraversal(tree.Root);
            tree.MirrorTree(tree.Root);
            List<int> mirroredInOrder = tree.InOrderTraversal(tree.Root);

            // Assert
            Assert.Equal(expectedOriginalInOrder, originalInOrder);
            Assert.Equal(expectedMirroredInOrder, mirroredInOrder);
        }

        [Fact]
        public void TestMirrorTree_WithSingleNode()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);

            List<int> expectedInOrder = new List<int> { 1 };

            // Act
            List<int> originalInOrder = tree.InOrderTraversal(tree.Root);
            tree.MirrorTree(tree.Root);
            List<int> mirroredInOrder = tree.InOrderTraversal(tree.Root);

            // Assert
            Assert.Equal(expectedInOrder, originalInOrder);
            Assert.Equal(expectedInOrder, mirroredInOrder);
        }

        [Fact]
        public void TestMirrorTree_WithEmptyTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            List<int> expectedInOrder = new List<int>(); // Empty list for an empty tree

            // Act
            List<int> originalInOrder = tree.InOrderTraversal(tree.Root);
            tree.MirrorTree(tree.Root);
            List<int> mirroredInOrder = tree.InOrderTraversal(tree.Root);

            // Assert
            Assert.Equal(expectedInOrder, originalInOrder);
            Assert.Equal(expectedInOrder, mirroredInOrder);
        }

        [Fact]
        public void TestMirrorTree_WithUnbalancedTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(5);
            tree.Root.Left.Left = new Node(2);
            tree.Root.Left.Right = new Node(7);
            tree.Root.Left.Right.Left = new Node(6);

            List<int> expectedOriginalInOrder = new List<int> { 2, 5, 6, 7, 10 };
            List<int> expectedMirroredInOrder = new List<int> { 10, 7, 6, 5, 2 };

            // Act
            List<int> originalInOrder = tree.InOrderTraversal(tree.Root);
            tree.MirrorTree(tree.Root);
            List<int> mirroredInOrder = tree.InOrderTraversal(tree.Root);

            // Assert
            Assert.Equal(expectedOriginalInOrder, originalInOrder);
            Assert.Equal(expectedMirroredInOrder, mirroredInOrder);
        }
    }
}