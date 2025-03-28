namespace LINQPractise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Write a program in C# Sharp to display the number and frequency of a given number from an array.
            Expected Output :
            The number and the Frequency are :
            Number 5 appears 3 times
            Number 9 appears 2 times
            Number 1 appears 1 times
            */

            int[] arr1 = { 5, 5, 9, 9, 1 ,234,1231,123,2,234,2342,42,342,4,234,1,3,12,312,31,231,23,123,12,12,12,12,12,31,23,12,312,};

            var query = arr1.GroupBy(x => x)
                            .Select(x => new 
                            {
                                 Number = x.Key,
                                 Frequencies =x.Count()
                            })
                            .OrderByDescending(x => x.Frequencies)
                            .Take(3);

            foreach ( var item in query )
            {
                Console.WriteLine(item);
            }
        }
    }
}
