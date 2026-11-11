using Tyuiu.PonkratevMM.Sprint4.Task4.V28.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                {3, 3, 1, 1, 4},
                {2, 4, 2, 1, 5},
                {2, 2, 2, 2, 2},
                {1, 5, 4, 5, 4},
                {1, 2, 3, 2, 4}
            };

            int[,] wait = new int[5, 5]
            {
                {3, 3, 1, 1, 1},
                {1, 1, 1, 1, 5},
                {1, 1, 1, 1, 1},
                {1, 5, 1, 5, 1},
                {1, 1, 3, 1, 1}
            };

            int[,] res = ds.Calculate(matrix);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
