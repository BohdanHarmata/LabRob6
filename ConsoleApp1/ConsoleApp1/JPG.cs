using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Diagnostics;

namespace ConsoleApp1
{
    class JPG : AbstractHandler
    {
        public string fileName { get; set; }

        public string filePath { get; set; }

        public JPG(string filePath)
        {
            this.filePath = filePath;
        }

        public override void FileCreation(string filePath)
        {
            Bitmap jpg = new Bitmap(256, 256);
            Graphics g = Graphics.FromImage(jpg); 
                g.Clear(Color.DarkGreen);
            jpg.Save(filePath);
            fileName = Console.ReadLine() + ".jpg";
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
