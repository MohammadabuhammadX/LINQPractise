namespace LINQPractise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5. Write a program in C# Sharp to display the characters and frequency of each character in a given string.
                Test Data:
                Input the string: apple
                Expected Output:
                The frequency of the characters are :
                Character a: 1 times
                Character p: 2 times
                Character l: 1 times
                Character e: 1 times
            */


            string input =Console.ReadLine();

            var query = input.GroupBy(x => x)
                             .Select(x => new
                             {
                                 chr = x.Key,
                                 freq = x.Count()
                             });

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
