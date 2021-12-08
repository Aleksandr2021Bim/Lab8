using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Текстовый_файл
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Папка/числа.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
