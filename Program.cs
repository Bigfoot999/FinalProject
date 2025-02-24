using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"D:\FinalProject\UserRepo";
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileStream fs = new FileStream(path + @"\UserRepo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Hello World");
            sw.Flush();
            sw.Close();
            fs = new FileStream(path + @"\UserRepo.txt", FileMode.Open, FileAccess.Read);
            StreamWriter streamWriter = new StreamWriter(fs);
            

        }
    }
}
