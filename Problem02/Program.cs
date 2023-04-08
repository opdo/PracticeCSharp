using Problem02.Helpers;
using Problem02.Interfaces;
using System;
using System.Collections.Generic;

namespace Problem02
{
    internal class Program
    {
        /// <summary>
        /// Problem 2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // 2.01. Read list array from file
            // Input file path
            var filePath = ConsoleHelper.InputFilePath();

            // Read file
            var factory = new DataReaderFactory();
            IDataReader dataReader = factory.LoadDataReader(filePath);

            // Data type is not supported
            if (dataReader is null)
            {
                Environment.Exit(0);
            }

            // Define list array
            var listArray = new List<int[]>();
            listArray = dataReader.ReadArray(filePath);

            // Output
            Console.WriteLine("");
            Console.WriteLine("List array in file");
            ConsoleHelper.PrintArray(listArray);
            Console.WriteLine("");

            // 2.02. Build method
            // 2.03. Create method to return the list subarrays and maximum sum with data read from CSV file
            var subLength = ConsoleHelper.InputSubLength();
            Console.WriteLine("");
            ArrayHelper.FindMaxSubArray(listArray, subLength);

            // Pause
            Console.ReadKey();
        }
    }
}
