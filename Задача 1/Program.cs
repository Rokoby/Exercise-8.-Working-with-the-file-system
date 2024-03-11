using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\source\repos\Задание 8. Работа с файловой системой\Задача 1\bin\Task1. Check";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}