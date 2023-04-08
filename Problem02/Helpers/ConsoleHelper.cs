using System;
using System.Collections.Generic;
using System.IO;

namespace Problem02.Helpers
{
    public static class ConsoleHelper
    {
        public static string InputFilePath()
        {
            Console.Write("- File path: ");
            var filePath = Console.ReadLine();

            // Check if file is exist or not
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: file is not found, please try to input again");
                return InputFilePath();
            }

            return filePath;
        }

        public static void PrintArray(int[] data)
        {
            Console.Write("[" + string.Join(", ", data) + "]");
        }

        public static void PrintArray(List<int[]> data)
        {
            for (var i = 0; i < data.Count; i++)
            {
                Console.Write("- Array " + (i + 1) + ": ");
                PrintArray(data[i]);
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// User input sub length
        /// </summary>
        /// <returns></returns>
        public static int InputSubLength()
        {
            Console.Write("- Sub length: ");
            var userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int subLength))
            {
                Console.WriteLine("Error: Please input an integer");
                return InputSubLength();
            }
            else if (subLength <= 0)
            {
                Console.WriteLine("Error: Please input an integer > 0");
                return InputSubLength();
            }

            return subLength;
        }
    }
}
