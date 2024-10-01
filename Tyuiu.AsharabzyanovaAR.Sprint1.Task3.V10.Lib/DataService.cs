using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AsharabzyanovaAR.Sprint1.Task3.V10.Lib
{
    public class DataService    
    {
        public string NumberToMoney(double number)
        {
            number = Math.Round(number, 3);
            int rubles = 0;
            int kopeiki = 0;

            rubles = (int)number;
            double ost = (number - rubles) * 100;
            kopeiki = (int)ost;


            return $"{number} руб. - это {rubles} руб. {kopeiki} коп.";
        }

        
}
