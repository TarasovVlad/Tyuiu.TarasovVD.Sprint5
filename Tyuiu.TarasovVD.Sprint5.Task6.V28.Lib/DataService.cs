using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.TarasovVD.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string pattern = @"\b\d{4}\b";

            foreach (string line in File.ReadAllLines(path))
            {
                MatchCollection matches = Regex.Matches(line, pattern);
                count += matches.Count;
            }

            return count;
        }
    }
}
