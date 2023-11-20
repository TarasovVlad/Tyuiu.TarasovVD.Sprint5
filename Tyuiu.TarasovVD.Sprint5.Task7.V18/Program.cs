using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint5.Task7.V18.Lib;

namespace Tyuiu.TarasovVD.Sprint5.Task7.V18
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Тарасов Владислав Денисович | ПКТб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask7V18.txt (файл взять из архива   *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и        *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Заменить *");
            Console.WriteLine("* все удвоенные буквы нн на н.Полученный результат сохранить в            *");
            Console.WriteLine("* файл OutPutDataFileTask7V18.txt.                                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V18.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);



            Console.ReadKey();
        }
    }
}
