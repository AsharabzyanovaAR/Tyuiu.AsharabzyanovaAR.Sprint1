using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AsharabzyanovaAR.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double n = 0;
            int c = 0;
            n = x;
            c = (int)x;
            double res = (n - c) * 10;
            return (int)res;
            
        }
    }
}
