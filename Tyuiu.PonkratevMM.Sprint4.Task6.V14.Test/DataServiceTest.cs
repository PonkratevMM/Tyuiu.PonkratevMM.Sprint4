using Tyuiu.PonkratevMM.Sprint4.Task6.V14.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

            string[] wait = { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };

            string[] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
