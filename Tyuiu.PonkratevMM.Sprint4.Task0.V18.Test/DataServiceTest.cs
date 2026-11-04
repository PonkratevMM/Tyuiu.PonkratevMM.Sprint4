using Tyuiu.PonkratevMM.Sprint4.Task0.V18.Lib;

namespace Tyuiu.PonkratevMM.Sprint4.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            int res = ds.GetSumOddArrEl(array);
            int wait = 41;

            Assert.AreEqual(wait, res);
        }
    }
}