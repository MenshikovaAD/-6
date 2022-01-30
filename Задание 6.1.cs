using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод находит самое длиное слово в предложении
            Console.Write("Введите предложение, разделение слов предусмотрено пробелом, знаки препинания не используются" + Environment.NewLine);

            string startString = Console.ReadLine();
            string[] str = startString.Split();
            int maxlen = 0;
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.ReadKey();
        }
    }
}
