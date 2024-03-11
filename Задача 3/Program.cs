using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\source\repos\Задание 8. Работа с файловой системой\Задача 3\TextForTask3.txt";
            int numSymb = 0;
            int numStr = 0;
            int nWords = 0;
            string str = "";
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; sr.ReadLine() != null; i++)
                {
                    numStr++;
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < numStr; i++)
                {
                    str += sr.ReadLine();
                    str += " ";//для избежания слипания строк при последующем разделении на слова
                }
            }
            numSymb -= numStr; //учет добавленных разделителей между строками
            nWords = -1; // учет последнего разделителя в строке
            foreach (string s in str.Split())
            {
                nWords++;
            }

            foreach (char ch in str)
            {
                numSymb++;
            }
            Console.WriteLine("Количество символов в тексте - {0}, количество строк в тексте - {1}, количество слов в тексте - {2}", numSymb, numStr, nWords);
            Console.ReadKey();
        }
    }
}
