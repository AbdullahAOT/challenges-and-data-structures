using Xunit;
using System.Runtime.CompilerServices;
using FindDuplicatesArray;
namespace FindDuplicatesArrayTest
{
    public class UnitTest1
    {
        [Fact]
        public void FindDuplicatesArrayTest()
        {
            int[] arr = new int[] { 1, 2, 3, 1, 2, 3 };
            int[] arr2 = Program.FindDuplicatesArray(arr);
            int[] arr3 = new int[] { 1, 2, 3 };
            Assert.Equal(arr3, arr2);
        }
    }
}