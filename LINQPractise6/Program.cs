namespace LINQPractise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7. Write a program in C# Sharp to display numbers, multiplication of numbers with frequency and the frequency of a number in an array.
                Test Data :
                The numbers in the array are :
                5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
                Expected Output :
                Number Number*Frequency Frequency
                ------------------------------------------------
                5 15 3
                1 1 1
                9 9 1
                2 4 2
            */

            int[] testData = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var query = testData.GroupBy(num => num)
                                .Select(x => new
                                {
                                    Number = x.Key,
                                    NumberMultiple = x.Key * x.Count(),
                                    NumberCount = x.Count(),
                                });

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
