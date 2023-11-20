using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.TarasovVD.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(Math.Sin(Convert.ToDouble(strX)) + Math.Pow(Convert.ToDouble(strX), 2) / 2, 3);
            return res;
        }
    }
}
