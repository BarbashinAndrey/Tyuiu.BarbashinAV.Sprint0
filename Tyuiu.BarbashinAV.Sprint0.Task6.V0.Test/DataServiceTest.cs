using Tyuiu.BarbashinAV.Sprint0.Task6.V0.Lib;
namespace Tyuiu.BarbashinAV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private static readonly int[] numbers = {1, 2, 3, 4, 5};

        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            Assert.AreEqual(15, DataService.AdditionArray(numbers));
        }

        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            Assert.AreEqual(-15, DataService.SubtractionArray(numbers));
        }

        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            Assert.AreEqual(120, DataService.MultiplicationArray(numbers));
        }
    }
}