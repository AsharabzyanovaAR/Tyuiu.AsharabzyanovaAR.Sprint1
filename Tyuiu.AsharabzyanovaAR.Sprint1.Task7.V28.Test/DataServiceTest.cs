using Tyuiu.AsharabzyanovaAR.Sprint1.Task7.V28.Lib;
using System.Net.WebSockets;

namespace Tyuiu.AsharabzyanovaAR.Sprint1.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait =9.787;
            Assert.AreEqual(wait, ds.Calculate(x, y));

            
        }
    }
}
