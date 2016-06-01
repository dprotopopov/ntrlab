using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ntrlab.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 1, 2, 3, 4, 6, 6, 6, 7 };
            var index = BinarySearch.search(arr, 5);
            Assert.IsTrue(index == 4);
            index = BinarySearch.search(arr, 6);
            Assert.IsTrue(index == 4);
            index = BinarySearch.search(arr, 2);
            Assert.IsTrue(index == 1);
            index = BinarySearch.search(arr, 1);
            Assert.IsTrue(index == 0);
            index = BinarySearch.search(arr, 9);
            Assert.IsTrue(index == 7);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { 1, 1, 2, 3, 4, 6, 6, 6, 7 };
            var index = BinarySearch.search(arr, 5);
            Assert.IsTrue(index == 5);
            index = BinarySearch.search(arr, 6);
            Assert.IsTrue(index == 5);
            index = BinarySearch.search(arr, 1);
            Assert.IsTrue(index == 0);
        }
    }
}