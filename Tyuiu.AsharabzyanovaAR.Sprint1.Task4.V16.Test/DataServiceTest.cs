using Tyuiu.AsharabzyanovaAR.Sprint1.Task4.V16.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.AsharabzyanovaAR.Sprint1.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -3;
            double wait = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait,res);
        }
    }
}
