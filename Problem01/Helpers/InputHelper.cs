using System;

namespace Problem01.Helpers
{
    public static class InputHelper
    {
        public static string DefaultContent = "One of the world's biggest festivals hit the streets of London";

        /// <summary>
        /// Input content of an article
        /// </summary>
        /// <returns></returns>
        public static string InputContent()
        {
            Console.Write("- Content of an article (left it emplty if you want to input the default string): ");
            var userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                userInput = DefaultContent;
            }

            return userInput;
        }

        /// <summary>
        /// Input max length
        /// </summary>
        /// <returns></returns>
        public static int InputMaxLength()
        {
            Console.Write("- Max length: ");
            var userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int maxLength))
            {
                Console.WriteLine("Error: Please input an integer");
                return InputMaxLength();
            }
            else if (maxLength <= 0) {
                Console.WriteLine("Error: Please input an integer > 0");
                return InputMaxLength();
            }

            return maxLength;
        }
    }
}
