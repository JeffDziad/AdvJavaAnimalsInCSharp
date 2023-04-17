using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvJavaAnimalsInCSharp.io
{
    public class FileInput
    {
        public string[] lines
        {
            get;
            private set;
        }

        private string filePath;

        private FileStream fileStream;

        private int readIndex = 0;

        private bool initialized = false;

        public FileInput(string filePath)
        {
            this.filePath = filePath;
        }

        private string[] readFile()
        {
            fileStream = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while((line = reader.ReadLine()) != null) 
                {
                    list.Add(line);
                }
            }
            return list.ToArray();
        }

        public void fileRead()
        {
            if (!initialized) lines = readFile();
            foreach(string line in lines) 
            {
                Console.WriteLine(line);
            }
        }

        public string fileReadLine() 
        {
            if (!initialized) lines = readFile();
            if (readIndex >= lines.Length) return null;
            string line = lines[readIndex];
            readIndex++;
            return line;
        }

        public void fileClose()
        {
            fileStream.Close();
        }
    }
}
