using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class TXT : AbstractHandler
    {
        public string fileName { get; set; }

        public string filePath { get; set; }

        public TXT (string filePath)
        {
            this.filePath = filePath;
        }

        public override void  FileCreation(string filePath)
        {
                File.Create(filePath);
            fileName = Console.ReadLine() + ".txt";
        }

        public override void FileReduct(string filePath)
        {
            File.OpenWrite(filePath);
        }

        public override void FileOpen(string filePath, string fileName)
        {
            File.Open(filePath + fileName, FileMode.Open);
        }
    }
}
