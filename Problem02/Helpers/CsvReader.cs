using Problem02.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem02.Helpers
{
    /// <summary>
    /// CSV File Reader
    /// </summary>
    public class CsvReader : IDataReader
    {
        public List<int[]> ReadArray(string filePath)
        {
            List<int[]> listInt = new List<int[]>();

            // Read all line
            var lines = File.ReadAllLines(filePath);

            // Check one by one line
            for (var i = 0; i < lines.Length; i++)
            {
                var data = lines[i].Trim();
                if (string.IsNullOrEmpty(data))
                {
                    // Verify data, auto ignore row has error data and write log error row.
                    Console.WriteLine($"- Read data at line {i}: empty line");
                    continue;
                }

                var stringArray = data.Split(',').ToList();
                try
                {
                    listInt.Add(stringArray.Select(x => int.Parse(x)).ToArray());
                }
                catch
                {
                    // Verify data, auto ignore row has error data and write log error row.
                    Console.WriteLine($"- Read data at line {i}: wrong data");
                    continue;
                }
            }

            return listInt;
        }
    }
}
