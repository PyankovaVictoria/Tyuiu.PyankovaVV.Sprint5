using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.PyankovaVV.Sprint5.Task0.V17.Lib;

namespace Tyuiu.PyankovaVV.Sprint5.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Влад\source\repos\Tyuiu.PyankovaVV.Sprint5\Tyuiu.PyankovaVV.Sprint5.Task0.V17\bin\Debug\OutPutFiltTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
