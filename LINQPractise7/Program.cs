using System;
using System.Linq;

namespace LINQPractise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8. Write a program in C# Sharp to find a string that starts and ends with a specific character.
                Test Data :
                The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
                Input starting character for the string : A
                Input ending character for the string : M
                Expected Output :
                The city starting with A and ending with M is : AMSTERDAM
            */
            var testData = new string[] {
                "ROME",
                "LONDON",
                "NAIROBI",
                "CALIFORNIA",
                "ZURICH",
                "NEW DELHI",
                "AMSTERDAM",
                "ABU DHABI",
                "PARIS"
            };


            while (true)
            {
                var input1 = ReadStringInput("Enter The First Character (or type 'exit' to quit) :");
                if (IsExitCommand(input1)) break;
                var input2 = ReadStringInput("Enter The Second Character : ");
                if (IsExitCommand(input2)) break;

                var query = FindCities(testData, input1, input2);
                PrintResults(query, input1, input2);
            }
            Console.WriteLine("Thank you for using the program!");


            string ReadStringInput(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine();
            }
            bool IsExitCommand(string input)
            {
                return input.Equals("exit", StringComparison.OrdinalIgnoreCase);
            }
            static IQueryable<string> FindCities(string[] cities, string startChar, string endChar)
            {
                return cities.AsQueryable().Where(x => x.StartsWith(startChar.ToUpper()) && x.EndsWith(endChar.ToUpper()));
            }
            void PrintResults(IQueryable<string> cities, string startChar, string endChar)
            {
                if (cities.Any())
                {
                    foreach (var city in cities)
                    {
                        Console.WriteLine($"The city starts with '{startChar}' and ends with '{endChar}' is : {city}");
                    }
                }
                else
                {
                    Console.WriteLine($"There are no cities that start with '{startChar}' and end with '{endChar}'.");
                }
            }
        }
    }
}
