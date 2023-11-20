using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint5.Task6.V28.Lib;

namespace Tyuiu.TarasovVD.Sprint5.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тарасов В. Д. | ПКТб-23-2 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Тарасов Владислав Денисович | ПКТб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask6V28.txt (файл взять из архива    ");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и        *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Найти    *");
            Console.WriteLine("* количество четырехзначных чисел в заданной строке.                      *");            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество четырехзначных чисел: " + res);



            Console.ReadKey();
        }
    }
}
