namespace LINQPractise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
                Expected Output:
                The numbers within the range of 1 to 11 are :
                1 3 6 9 10
            */

            int[] n1 = {1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};

            var query = from num in n1
                        where num > 0
                        where num < 12
                        select num;

            foreach( var n in query )
            {
                Console.WriteLine( n);
            }

        }
    }
}
