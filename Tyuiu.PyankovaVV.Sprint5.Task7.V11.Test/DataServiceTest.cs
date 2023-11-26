using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PyankovaVV.Sprint5.Task7.V11.Lib;

namespace Tyuiu.PyankovaVV.Sprint5.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        { 
        }
    }
    string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";

    FileInfo fileinfo = new FileInfo(path);
    private bool fileExists = fileinfo.Exists;
    bool wait = true;
    Assert.AreEqual(wait, fileExists);
}
