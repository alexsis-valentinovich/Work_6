using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.    Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
//Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
//(пример палиндрома – «А роза упала на лапу Азора»).
namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Наберите предложение");
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            str = str.ToLower();
            string strRev = "";
            foreach (char letter in str)
            {
                    strRev = letter+strRev;
            }
            if (string.Compare(str, strRev) == 0)
            {
                Console.WriteLine("Есть. ПАЛИНДРОМ");
            }
            else
            {
                Console.WriteLine("Не является палиндромом");
            }
            Console.ReadLine();
        }
    }
}
