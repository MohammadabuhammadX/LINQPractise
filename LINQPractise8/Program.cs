namespace LINQPractise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9. Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
                Test Data :
                The members of the list are :
                55 ,200 ,740 ,76 ,230 ,482 ,95
                Expected Output :
                The numbers greater than 80 are :
                200
                740
                230
                482
                95
            */

            var testDataList = new List<int> { 55, 200, 740, 76, 230, 482, 95 };


            var query = testDataList.FindAll(x => x > 80 ? true : false);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
