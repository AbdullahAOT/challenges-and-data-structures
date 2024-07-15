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
    }
}