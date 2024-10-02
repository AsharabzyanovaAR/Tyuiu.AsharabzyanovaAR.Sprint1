using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AsharabzyanovaAR.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {



            string[] c=value.Split(' ');
            string resultat = "";
            foreach (string s in c)
            {
                resultat += s.Remove(s.Length - 1, 1);
            }
            return resultat;





        }
    }
}
