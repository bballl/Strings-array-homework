using System;

namespace StringsArrayHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Синий", "трактор", "клевый", "мультик", "!", ":-)" };
            Console.WriteLine("Исходный массив:");

            foreach (string item in array)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 3)
                {
                    array[i] = array[i].Substring(0, 3);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Конечный массив:");
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}

