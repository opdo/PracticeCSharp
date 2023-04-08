using Problem01.Helpers;
using System;

namespace Problem01
{
    internal class Program
    {
        /// <summary>
        /// Problem 01: Summary of an article
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // User input summary and max length
            var content = InputHelper.InputContent();
            var maxLength = InputHelper.InputMaxLength();

            // Output
            Console.WriteLine("Summary: " + GetArticleSummary(content, maxLength));
            Console.ReadKey();
        }

        static public string GetArticleSummary(string content, int maxLength)
        {
            if (maxLength >= content.Length)
            {
                return content;
            }

            var summary = string.Empty;

            // Loop one by one word in content
            foreach (var item in content.Split(' '))
            {
                // Check the new length, if it equals or greater than maxLength, exit the loop
                if (summary.Length + item.Length >= maxLength)
                {
                    break;
                }

                // Concat the word to summary
                summary += (string.IsNullOrEmpty(summary) ? "" : " ") + item;
            }

            return summary + "...";
        }
    }
}
