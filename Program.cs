using System;

namespace StringsArrayHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Hello", "2", "world", ":-)" };
            string[] newArray;
            int counter = 0;
            
            Console.WriteLine("Исходный массив:");
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    counter++;
                }
            }

            newArray = new string[counter];
            counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[counter] = array[i];
                    counter++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Конечный массив:");
            foreach (string item in newArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}

