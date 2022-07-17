using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.    Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
//Знаки препинания не используются. Найти самое длинное слово в строке.
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Наберите предложение");
            string str = Console.ReadLine();
            string[] strArr = str.Split();
            string maxStr = strArr[0];
            foreach (string str2 in strArr)
            {
                if (str2.Length > maxStr.Length)
                    maxStr = str2;
            }

            Console.WriteLine("Самое длинное слово есть: {0}", maxStr);
            Console.ReadLine();
        }
    }
}
