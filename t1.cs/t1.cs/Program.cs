internal class Program
{
    private static void Main(string[] args)
    {
        int marks;
        Console.WriteLine("Enter the marks:");
        marks = Convert.ToInt32(Console.ReadLine());
        if (marks > 50)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}