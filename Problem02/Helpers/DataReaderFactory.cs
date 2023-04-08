using Problem02.Interfaces;
using System;

namespace Problem02.Helpers
{
    public class DataReaderFactory
    {
        public IDataReader LoadDataReader(string filePath)
        {
            // Check file type by extension
            if (filePath.EndsWith(".csv")) return new CsvReader();
            else if (filePath.EndsWith(".json")) return new JsonReader();

            Console.WriteLine("Does not support this file type");
            Console.ReadKey();
            return null;
        }
    }
}
