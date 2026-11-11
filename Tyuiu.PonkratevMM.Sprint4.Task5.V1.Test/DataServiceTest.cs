using Tyuiu.PonkratevMM.Sprint4.Task5.V1.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task5.V1.Test
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
                { 8, -3, 2, -9, 2 },
                { -2, -7, 5, 8, 7 },
                { 4, 5, 1, -3, -2 },
                { 1, -2, -9, 0, -5 },
                { -1, 8, 8, -2, 7 }
            };

            int[,] wait = new int[5, 5]
            {
                { 1, -3, 1, -9, 1 },
                { -2, -7, 1, 1, 1 },
                { 1, 1, 1, -3, -2 },
                { 1, -2, -9, 0, -5 },
                { -1, 1, 1, -2, 1 }
            };

            int[,] res = ds.Calculate(matrix);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
