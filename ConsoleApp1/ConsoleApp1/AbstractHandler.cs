using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    abstract class AbstractHandler
    {
        string fileName { get; set; }
        string filePath { get; set; }

        public abstract void FileCreation(string filePath);

        public abstract void FileReduct(string filePath);

        public abstract void FileOpen(string filePath, string fileName);
  
        
    }
}
