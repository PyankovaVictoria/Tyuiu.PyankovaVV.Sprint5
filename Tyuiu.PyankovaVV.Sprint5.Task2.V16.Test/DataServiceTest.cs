using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PyankovaVV.Sprint5.Task2.V16.Lib;

namespace Tyuiu.PyankovaVV.Sprint5.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Влад\source\repos\Tyuiu.PyankovaVV.Sprint5\Tyuiu.PyankovaVV.Sprint5.Task2.V16\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
