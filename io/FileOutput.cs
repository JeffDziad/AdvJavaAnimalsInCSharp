using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvJavaAnimalsInCSharp.io
{
    public class FileOutput
    {
        private string filePath;

        private StreamWriter writer;

        public FileOutput(string _filePath) 
        {
            filePath = _filePath;
            writer = new StreamWriter(filePath);
        }

        public void fileWrite(string line)
        {
            writer.WriteLine(line);
        }

        public void fileClose()
        {
            writer.Close();
            writer.Dispose();
        }
    }
}
