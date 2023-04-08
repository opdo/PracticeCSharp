using System.Collections.Generic;

namespace Problem02.Interfaces
{
    public interface IDataReader
    {
        List<int[]> ReadArray(string filePath);
    }
}
