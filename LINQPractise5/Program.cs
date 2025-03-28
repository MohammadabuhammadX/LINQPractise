namespace LINQPractise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Write a program in C# Sharp to display the name of the days of the week.
                Expected Output:
                Sunday
                Monday
                Tuesday
                Wednesday
                Thursday
                Friday
                Saturday
            */


            //string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //var days = dayWeek.Select(i => i);

            //foreach (var day in days)
            //{
            //    Console.WriteLine(day);
            //}

            var daysOfWeek = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().Select(day=>day).ToArray();

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

        }
    }
}
