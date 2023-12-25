using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RagimovaMA.Sprint7.V5.Lib;
using System.IO;

namespace Tyuiu.RagimovaMA.Sprint7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidLoadFromFileData()
        {
            string path = @"C:\Users\honor\Desktop\bazaaaa\DataBase2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
