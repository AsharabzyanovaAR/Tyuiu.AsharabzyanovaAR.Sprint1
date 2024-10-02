using Tyuiu.AsharabzyanovaAR.Sprint1.Task6.V7.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strTest = "алина малина калина";
            string res = ds.DeleteLastLetter(strTest);
            string wait = "алин малин калин";
            Assert.AreEqual(wait, res);


        }
    }
}
