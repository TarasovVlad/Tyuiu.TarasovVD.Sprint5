using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint5.Task3.V20.Lib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tyuiu.TarasovVD.Sprint5.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            Console.Title = "Спринт #5 | Выполнил: Тарасов В. Д. | ПКТб-23-2 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Тарасов Владислав Денисович | ПКТб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение y(x) = x / (sqrt(x^2 + x)) вычислить его значение при    *");
            Console.WriteLine("* x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin и        *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Console.WriteLine("Значение выражения = " + result);
            }


            Console.ReadKey();
        }
    }
}
