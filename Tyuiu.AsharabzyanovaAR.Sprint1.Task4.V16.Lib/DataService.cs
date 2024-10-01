using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AsharabzyanovaAR.Sprint1.Task4.V16.Lib
{
    public class DataService : ISprint1Task4V16
    {
        public double Calculate(double x)
        {
            
            var res = 1 / (x + 4);

            double v = Math.Round(res, 3);
            return v;
        }
    }
}
