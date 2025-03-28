namespace LINQPractise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find the number of an array and the square of each number.
                Expected Output :
                { Number = 9, SqrNo = 81 }
                { Number = 8, SqrNo = 64 }
                { Number = 6, SqrNo = 36 }
                { Number = 5, SqrNo = 25 }
            */

            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var query = arr1.Select(x => new 
            {
                num =x,
                Sqr = x*x
            });

            foreach (var x in query)
            {
                Console.WriteLine($"Number : {x.num} , Square : {x.Sqr}");
            }
        }
    }
}
