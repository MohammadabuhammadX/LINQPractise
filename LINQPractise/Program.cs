namespace LINQPractise
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() 
            {
                0,2,4,6,8
            };

            var evenNumbers = num.Where(n => n % 2 == 0);

            Console.WriteLine("Even Numbers");
            foreach (int n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}

//testing gitbot testttttttttttttttttt