using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();
            string[] st = input.Split(new Char[] {' '});
            int max = 0, index = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i].Length > max)
                {
                    max = st[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово в предложении : {0}", st[index]);
            Console.ReadLine();
        }
    }
}
