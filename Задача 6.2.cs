using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод находит самое длиное слово в предложении
            Console.Write("Введите предложение, разделение слов предусмотрено пробелом, знаки препинания не используются" + Environment.NewLine);

            string startString = Console.ReadLine();
            string str2 = startString.ToLower();
            string[] str3 = str2.Split();
            string str4 = string.Join("", str3);
            string str5 = new string(str4.Reverse().ToArray());
            Console.Write(" " + Environment.NewLine);    
            if (str4 == str5) 
                {
                Console.Write("Слово является полиандромом");
                }
            else
            {
                Console.Write("Слово не является полиандромом");
            }

            Console.ReadKey();
            
        }
    }
}
