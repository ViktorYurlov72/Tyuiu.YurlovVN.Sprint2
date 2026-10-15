using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.YurlovVN.Sprint2.Task6.V7.Lib;

namespace Tyuiu.YurlovVN.Sprint2.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите порядковый количество месяцев n: ");
            int startYear, n;
            startYear = 1990;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Мы начнем с: " + startYear + " года " + "и прибавим: " + n + " месяца/ев");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.FindMonthName(startYear, n);
            Console.WriteLine("У вас получился: " + res);
            Console.ReadKey();
        }
    }
}