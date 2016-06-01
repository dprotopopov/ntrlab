using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ntrlab1.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { -1, -1, 2, 2, 2, -3, -3, 4, -5 };
            var arr1 = LargestSum.shrink(arr);
            Assert.IsTrue(arr1[0] == 6);
            Assert.IsTrue(arr1[1] == -6);
            Assert.IsTrue(arr1[2] == 4);
            Assert.IsTrue(arr1[3] == -5);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { -1, -1, 2, 2, 2, -3, 4, -5 };
            int value = LargestSum.find(arr);
            Assert.IsTrue(value == 7);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = { 2, 2, 2, -2, -3, 7, -5 };
            int value = LargestSum.find(arr);
            Assert.IsTrue(value == 8);
        }
    }
}