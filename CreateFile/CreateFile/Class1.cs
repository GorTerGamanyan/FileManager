using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    public static class Class1
    {
        public static void NewTextFile(string path,string text)
        {

            if (File.Exists(path))
            {
                throw new Exception("File exist");
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                sw.Write(text);
                sw.Close();
            }
        }

        public static void MyDelet(string path)
        {
            if(!File.Exists(path))
            {
                throw new Exception("Can't find file");
            }
            File.Delete(path);
        }
    }
}
