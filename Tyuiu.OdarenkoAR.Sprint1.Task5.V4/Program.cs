using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.OdarenkoAR.Sprint1.Task5.V4.Lib;
namespace Tyuiu.OdarenkoAR.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Одаренко А. Р. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила Одаренко А. Р. | ИСПб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Идёт k-я секунда суток.                                                 *");
            Console.WriteLine("* Определить сколько полных часов прошло к этому моменту.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int k;
            Console.WriteLine("Введите количество секунд K = ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Прошло полных часов = " + ds.SecondsToHours(k));
            Console.ReadKey();
        }
    }
}
