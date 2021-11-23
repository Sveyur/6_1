using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] array = str.Split();
            int max = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > max)
                {
                    max = array[i].Length;
                    index = i;
                }
                
            }
            Console.WriteLine("Самое длинное слово {0}", array[index]);
            Console.ReadKey();
        }
    }
}
