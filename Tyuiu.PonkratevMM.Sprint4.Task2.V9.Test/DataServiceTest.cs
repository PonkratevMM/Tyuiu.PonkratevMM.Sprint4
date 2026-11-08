using Tyuiu.PonkratevMM.Sprint4.Task2.V9.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 7, 7, 5, 5, 2, 6, 3, 3, 3, 1, 2, 1, 1, 1 };

            int res = ds.Calculate(array);
            int wait = 24;

            Assert.AreEqual(wait, res);
        }
    }
}
