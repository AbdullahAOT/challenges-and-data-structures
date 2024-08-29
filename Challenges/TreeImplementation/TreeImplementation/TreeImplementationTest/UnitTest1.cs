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
        [Fact]
        public void TestFindSecondMax_WithMultipleNodes()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(5);
            tree.Root.Right = new Node(20);
            tree.Root.Left.Left = new Node(3);
            tree.Root.Left.Right = new Node(7);
            tree.Root.Right.Left = new Node(15);
            tree.Root.Right.Right = new Node(25);

            int expectedSecondMax = 20;

            // Act
            int? secondMax = tree.FindSecondMax();

            // Assert
            Assert.Equal(expectedSecondMax, secondMax);
        }

        [Fact]
        public void TestFindSecondMax_WithSingleNode()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);

            // Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => tree.FindSecondMax());
            Assert.Equal("Tree has fewer than two unique values", exception.Message);
        }

        [Fact]
        public void TestFindSecondMax_WithEmptyTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => tree.FindSecondMax());
            Assert.Equal("Tree is empty", exception.Message);
        }

        [Fact]
        public void TestFindSecondMax_WithNegativeValues()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(-10);
            tree.Root.Left = new Node(-20);
            tree.Root.Right = new Node(-5);

            int expectedSecondMax = -10;

            // Act
            int? secondMax = tree.FindSecondMax();

            // Assert
            Assert.Equal(expectedSecondMax, secondMax);
        }

        [Fact]
        public void TestFindSecondMax_WithIdenticalValues()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(10);
            tree.Root.Right = new Node(10);

            // Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => tree.FindSecondMax());
            Assert.Equal("Tree has fewer than two unique values", exception.Message);
        }
        [Fact]
        public void TestSumOfLeafNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(9);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(12);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(17);
            Btree.Root.Right.Right = new Node(23);
            Btree.Root.Left.Left.Right = new Node(4);

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(51, leafSum); // 4 + 7 + 17 + 23 = 51
        }

        [Fact]
        public void TestEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(0, leafSum);
        }

        [Fact]
        public void TestSingleNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(5);

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(5, leafSum);
        }

    }
}