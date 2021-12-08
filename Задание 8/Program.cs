using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Числа.txt";
            Random random = new Rendom();
            // статический метод
            // if (!Directory.Exists(path)) ;
            // {
            //   Directory.CreateDirectory(path);
            //}
            // динамическиу метод
            //DirectoryInfo directory = new DirectoryInfo(path);
            //if (!directory.Exists)
            //{
            //   directory.Create();
            // }
            //Console.ReadKey();
            //создадим текстовый файл
            // if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            using (StreamWriter sw = new StreamWriter(path))
            {
                // sw.WriteLine("Программа суммы случайных 10 чисел");
                // int[] array = new int[10];               
                // int S = 0;
                for (int i = 0; i < 10; i++)
                {
                    int X = random.Next(0,10);
                    //S += array[i];
                    sw.WriteLine(X);
                   // Console.WriteLine();
                    //Console.WriteLine("Сумма чисел равна {0}", S);
                }
            }
            int S = 0;
            using(StreamReader sr=new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int X = Convert.ToInt32(sr.ReadLine());
                    S += X;
                }
                //Console.WriteLine(sr.ReadToEnd());
            }
            Console.WriteLine("Сумма десяти случайных чисел равна {0}", S);
            Console.ReadKey();
        }
    }
}
