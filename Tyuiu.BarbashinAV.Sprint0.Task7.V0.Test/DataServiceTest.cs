using Tyuiu.BarbashinAV.Sprint0.Task7.V0.Lib;
namespace Tyuiu.BarbashinAV.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            var nums1 = new int[] { 1, 1, 1, 1, 1 };
            var nums2 = new int[] { 1, 1, 1, 1, 1 };
            var nums3 = new int[] { 2, 2, 2, 2, 2 };

            CollectionAssert.AreEqual(nums3, DataService.AdditionArrays(nums1, nums2));
        }
    }
}