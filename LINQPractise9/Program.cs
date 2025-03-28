namespace LINQPractise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10. Write a program in C# Sharp to accept list members through the keyboard and display them more than a specific value.
                Test Data :
                Input the number of members on the List : 5
                Member 0 : 10
                Member 1 : 48
                Member 2 : 52
                Member 3 : 94
                Member 4 : 63
                Input the value above you want to display the members of the List : 59
                Expected Output :
                The numbers greater than 59 are :
                94
                63
            */
            int numberOfMembers = GetNumberOfMembers();
            List<int> members = GetMembers(numberOfMembers);
            int threshold = GetThresholdValue();
            DisplayMembersAboveThreshold(members, threshold);

        }
        static int GetNumberOfMembers()
        {
            Console.Write("Input the number of members on the List: ");
            return int.Parse(Console.ReadLine()); 
        }

        static List<int> GetMembers(int count)
        {
            List<int> members = new List<int>();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Member {i} : ");
                int member = int.Parse(Console.ReadLine()); 
                members.Add(member);
            }

            return members;
        }

        static int GetThresholdValue()
        {
            Console.Write("Input the value above you want to display the members of the List: ");
            return int.Parse(Console.ReadLine());
        }

        static void DisplayMembersAboveThreshold(List<int> members, int threshold)
        {
            Console.WriteLine($"The numbers greater than {threshold} are:");

            var filteredMembers = members.Where(x => x > threshold);
            foreach (var member in filteredMembers)
            {
                Console.WriteLine(member);
            }
        }
    }
}
