using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    class DOCX : AbstractHandler
    {
        public string fileName { get; set; }

        public string filePath { get; set; }

        public DOCX(string filePath)
        {
            this.filePath = filePath;
        }

        public override void FileCreation(string filePath)
        {
            File.Create(filePath);
            fileName = Console.ReadLine() + ".docx";
        }

        public override void FileReduct(string filePath)
        {
            File.OpenWrite(filePath);
        }

        public override void FileOpen(string filePath, string fileName)
        {
            Process.Start(filePath + fileName);
        }
    }
}
