using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint5.Task1.V14.Lib;
using System.IO;

namespace Tyuiu.TarasovVD.Sprint5.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Тарасов В. Д. | ПКТб-23-2 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Тарасов Владислав Денисович | ПКТб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = sin(x)/(x + 1,7) - cos(x) * 4x - 6 ( произвести    *");
            Console.WriteLine("* табулирование f(x) на заданном диапазоне [-5;5] с шагом 1. Произвести   *");
            Console.WriteLine("* проверку деления на 0. При делении на ноль вернуть значение 0.Результат *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в   *");
            Console.WriteLine("* таблицу. Значения округлить до двух знаков после запятой.               *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            using (StreamReader reader = new StreamReader(res))
            {
                Console.WriteLine("+----------+----------+");
                Console.WriteLine("|    X     |    f(x)  |");
                Console.WriteLine("+----------+----------+");

                for (int i = 0; i <= 10; i++)
                {
                    string line = reader.ReadLine();
                    double result = Convert.ToDouble(line);
                    Console.WriteLine("|{0,5:d}     |  {1,8:f2}   |", startValue, result);
                    startValue++;
                }
                Console.WriteLine("+----------+----------+");
            }

            Console.ReadKey();
        }
    }
}
