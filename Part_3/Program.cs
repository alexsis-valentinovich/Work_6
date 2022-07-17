using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.    Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. В строке может быть несколько фрагментов,
//заключённых в фигурные скобки. Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
namespace Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Наберите предложение");
            string str = Console.ReadLine();
            int k = 0;
            int begin = -1;
            int end = -1;
            while ((str.Contains("{") == true) || (str.Contains("}") == true))
            {
                foreach (char letter in str)
                {
                    if (letter == '{')
                    {
                        begin = k;
                    }
                    if ((letter == '}') && (begin != -1))
                    {
                        end = k;
                    }
                    if ((begin != -1) && (end != -1))
                    {
                        str = str.Remove(begin, end - begin + 1);
                        k -= (end - begin + 1);
                        begin = -1;
                        end = -1;
                    }
                    k++;
                }
                Console.WriteLine("Промежуточная строка - \"{0}\"", str);
                begin = -1;
                end = -1;
                k = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Новая строка - \"{0}\"", str);
            Console.ReadLine();
        }
    }
}
