using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово или строку: ");
            string str = Console.ReadLine();
            str = str.ToLower();
            string[] array = str.Split();
            string whtspc = "";
            string reverseStr = "";


            for (int i = 0; i <= array.Length - 1; i++)
            {
                whtspc += array[i];
            }


            for (int i = whtspc.Length - 1; i >= 0; i--)
            {
                reverseStr += whtspc.Substring(i, 1);
            }          

            if (whtspc == reverseStr)
            {
                Console.WriteLine("Поздравляем! Введенная строка или слово является палиндромом");
            }
            else
                Console.WriteLine("Увы! Введенная строка или слово не является палиндромом");

            Console.ReadKey();
        }
    }
}
