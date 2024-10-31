using Xunit;
using System.Runtime.CompilerServices;
using LinkedListApplication;
namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveTest()
        {
            LinkedList list = new LinkedList();
            list.AddToLinkedList(1);
            list.AddToLinkedList(2);
            list.AddToLinkedList(3);
            list.LinkedListRemove(3);
            Assert.Equal(2, list.tail.value);
        }
        [Fact]
        public void PrintTest()
        {
            var list = new LinkedList();
            list.AddToLinkedList(1);
            list.AddToLinkedList(2);
            list.AddToLinkedList(3);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            list.PrintLinkedList();
            var output = stringWriter.ToString();
            var expectedOutput = "1\r\n2\r\n3\r\n";
            Assert.Equal(expectedOutput, output);
        }
        [Fact]
        public void RemoveDuplicates_NoDuplicates_ListUnchanged()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.AddToLinkedList(1);
            list.AddToLinkedList(2);
            list.AddToLinkedList(3);

            // Act
            list.RemoveDuplicates();

            // Assert
            Assert.Equal(3, list.length);
            Assert.Equal(1, list.head.value);
            Assert.Equal(2, list.head.next.value);
            Assert.Equal(3, list.tail.value);
        }

        [Fact]
        public void RemoveDuplicates_SomeDuplicates_DuplicatesRemoved()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.AddToLinkedList(1);
            list.AddToLinkedList(2);
            list.AddToLinkedList(2);
            list.AddToLinkedList(3);
            list.AddToLinkedList(3);
            list.AddToLinkedList(4);

            // Act
            list.RemoveDuplicates();

            // Assert
            Assert.Equal(4, list.length);
            Assert.Equal(1, list.head.value);
            Assert.Equal(2, list.head.next.value);
            Assert.Equal(3, list.head.next.next.value);
            Assert.Equal(4, list.tail.value);
        }

        [Fact]
        public void RemoveDuplicates_AllDuplicates_SingleNodeRemains()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.AddToLinkedList(5);
            list.AddToLinkedList(5);
            list.AddToLinkedList(5);
            list.AddToLinkedList(5);

            // Act
            list.RemoveDuplicates();

            // Assert
            Assert.Equal(1, list.length);
            Assert.Equal(5, list.head.value);
            Assert.Null(list.head.next);
            Assert.Equal(5, list.tail.value);
        }
        [Fact]
        public void RotateByZero_ShouldNotChangeList()
        {
            // Arrange
            var list = new LinkedList();
            list.AddToLinkedList(1);
            list.AddToLinkedList(2);
            list.AddToLinkedList(3);
            list.AddToLinkedList(4);

            // Act
            list.RotateLeft(0);

            // Assert
            Assert.Equal("1 -> 2 -> 3 -> 4 -> Null", GetListAsString(list));
        }

        [Fact]
        public void RotateByGreaterThanLength_ShouldRotateCorrectly()
        {
            // Arrange
            var list = new LinkedList();
            list.AddToLinkedList(1);
            list.AddToLinkedList(2);
            list.AddToLinkedList(3);

            // Act
            list.RotateLeft(7); // 7 % 3 = 1, so this is equivalent to rotating by 1

            // Assert
            Assert.Equal("2 -> 3 -> 1 -> Null", GetListAsString(list));
        }

        [Fact]
        public void RotateByLength_ShouldNotChangeList()
        {
            // Arrange
            var list = new LinkedList();
            list.AddToLinkedList(10);
            list.AddToLinkedList(20);
            list.AddToLinkedList(30);
            list.AddToLinkedList(40);

            // Act
            list.RotateLeft(4); // Rotate by list length

            // Assert
            Assert.Equal("10 -> 20 -> 30 -> 40 -> Null", GetListAsString(list));
        }

        [Fact]
        public void RotateByTwo_ShouldRotateList()
        {
            // Arrange
            var list = new LinkedList();
            list.AddToLinkedList(1);
            list.AddToLinkedList(2);
            list.AddToLinkedList(3);
            list.AddToLinkedList(4);
            list.AddToLinkedList(5);
            list.AddToLinkedList(6);

            // Act
            list.RotateLeft(2);

            // Assert
            Assert.Equal("3 -> 4 -> 5 -> 6 -> 1 -> 2 -> Null", GetListAsString(list));
        }

        [Fact]
        public void RotateSingleElementList_ShouldNotChangeList()
        {
            // Arrange
            var list = new LinkedList();
            list.AddToLinkedList(5);

            // Act
            list.RotateLeft(1);

            // Assert
            Assert.Equal("5 -> Null", GetListAsString(list));
        }

        [Fact]
        public void RotateEmptyList_ShouldNotChangeList()
        {
            // Arrange
            var list = new LinkedList();

            // Act
            list.RotateLeft(3);

            // Assert
            Assert.Equal("Null", GetListAsString(list));
        }

        // Helper method to convert the linked list to a string representation for easy comparison
        private string GetListAsString(LinkedList list)
        {
            var result = "";
            var node = list.head;
            while (node != null)
            {
                result += node.value + " -> ";
                node = node.next;
            }
            result += "Null";
            return result;
        }
    }
}