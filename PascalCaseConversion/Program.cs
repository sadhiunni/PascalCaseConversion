using System;
using System.Text;

namespace PascalCaseConversion
{
    class Program
    {
        /*
         * The user has to enter a few words separated by a space. 
         * The words are used to create a variable name with PascalCase.
         * For example, if the user types: "number of students", display "NumberOfStudents". 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name seperated by space : ");
            var input = Console.ReadLine();
            //getting the input that has to be converted to pascal case
            Console.WriteLine("\n\nThe name entered is converted to a variable name following Pascal Case : ");
            Console.WriteLine(ConvertPascalCase(input));
        }
        public static StringBuilder ConvertPascalCase(string input) 
        {
            StringBuilder builder = new StringBuilder();
            String[] inputWords = input.Split(" ");
            for (int i = 0; i < inputWords.Length; i++)
            {
                string x = inputWords[i].ToLower();
                string y = x.Substring(1);
                builder.Append(char.ToUpper(x[0])).Append(y);
            }
            return builder;
        }
    }
}
