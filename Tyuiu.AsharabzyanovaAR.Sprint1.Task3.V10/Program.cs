using Tyuiu.AsharabzyanovaAR.Sprint1.Task3.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = ("Спринт #1 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
        Console.WriteLine("* Задание #3                                                             *");
        Console.WriteLine("* Вариант #10                                                              *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        
        double number;
        Console.Write("number =");
        number = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(ds.NumberToMoney(number));

        Console.ReadKey();
    }
}