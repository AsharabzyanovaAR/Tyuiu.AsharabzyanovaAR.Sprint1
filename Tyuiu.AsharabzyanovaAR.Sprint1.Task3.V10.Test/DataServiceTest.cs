using System.Data;
using Tyuiu.AsharabzyanovaAR.Sprint1.Task3.V10.Lib;

namespace Tyuiu.AsharabzyanovaAR.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual($"23,6 руб. - это 23 руб. 60 коп.", ds.NumberToMoney(23.6));
        }
    }
}
