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
    }
}