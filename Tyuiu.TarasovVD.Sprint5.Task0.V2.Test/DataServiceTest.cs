using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint5.Task0.V2.Lib;
using System.IO;

namespace Tyuiu.TarasovVD.Sprint5.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.TarasovVD.Sprint5\Tyuiu.TarasovVD.Sprint5.Task0.V2\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
