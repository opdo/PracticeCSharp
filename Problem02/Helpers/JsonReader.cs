using Newtonsoft.Json;
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
    public class JsonReader : IDataReader
    {
        public List<int[]> ReadArray(string filePath)
        {
            List<int[]> listInt = new List<int[]>();

            // Read all line
            var jsonText = File.ReadAllText(filePath);
            var jsonArray = JsonConvert.DeserializeObject<List<dynamic>>(jsonText);

            // Check one by one line
            for (var i = 0; i < jsonArray.Count; i++)
            {
                var data = jsonArray[i].ToString();

                try
                {
                    int[] array = JsonConvert.DeserializeObject<int[]>(data);
                    if (array is null)
                    {
                        // Verify data, auto ignore row has error data and write log error row.
                        Console.WriteLine($"- Read data at array {i}: empty line");
                        continue;
                    }

                    listInt.Add(array);
                }
                catch
                {
                    // Verify data, auto ignore row has error data and write log error row.
                    Console.WriteLine($"- Read data at array {i}: wrong data");
                    continue;
                }
            }

            return listInt;
        }
    }
}
