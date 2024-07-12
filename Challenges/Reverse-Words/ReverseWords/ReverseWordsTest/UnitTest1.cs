using Xunit;
using System.Runtime.CompilerServices;
using ReverseWords;
namespace ReverseWordsTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestCase1()
        {
            String actualResult = Program.ReverseWordsFunction("csharp is programming language");
            Assert.Equal("language programming is csharp", actualResult);
        }
        [Fact]
        public void TestCase2()
        {
            String actualResult = Program.ReverseWordsFunction("Reverse the words in this sentence");
            Assert.Equal("sentence this in words the Reverse", actualResult);
        }
        [Fact]
        public void TestCase3()
        {
            String actualResult = Program.ReverseWordsFunction("challenges and data structures");
            Assert.Equal("structures data and challenges", actualResult);
        }
    }
}