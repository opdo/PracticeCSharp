using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem02.Helpers
{
    public static class ArrayHelper
    {
        static public int FindMaxSubArray(int[] inputArray, int subLength)
        {
            // Print List subarrays
            Console.Write("List subarrays of ArrayList ");
            ConsoleHelper.PrintArray(inputArray);
            Console.WriteLine("");

            var listSubArray = new List<int[]>();
            if (inputArray.Length < subLength)
            {
                throw new Exception("- Sub Length is greater than array length");
            }

            int start = 0;
            int end = subLength - 1;
            while (end < inputArray.Length)
            {
                // Create sub array
                var subArray = new int[subLength];
                var index = 0;
                for (var i = start; i <= end; i++)
                {
                    subArray[index++] = inputArray[i];
                }
                listSubArray.Add(subArray);

                start++;
                end++;
            }

            // Find max
            int? max = null;
            foreach (var subArray in listSubArray)
            {
                Console.Write("\t");
                ConsoleHelper.PrintArray(subArray);

                // Calculate array sum
                var arraySum = subArray.Sum();
                if (max is null || arraySum > max.Value)
                {
                    max = arraySum;
                }

                Console.WriteLine(" sum is " + arraySum);
            }

            return max.Value;
        }

        static public void FindMaxSubArray(List<int[]> inputArray, int subLength)
        {
            foreach (var array in inputArray)
            {
                try
                {
                    var max = FindMaxSubArray(array, subLength);
                    Console.WriteLine("Maximum sum: " + max);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
