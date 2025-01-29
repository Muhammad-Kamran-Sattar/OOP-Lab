internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int sum = 0;
        Console.WriteLine("Enter number:");
        num = Convert.ToInt32(Console.ReadLine());

        do
        {
            sum = sum + num;
            Console.WriteLine("Enter number:");
            num = Convert.ToInt32(Console.ReadLine());
        }
        while (num != -1);
        sum = sum + 1;
            Console.WriteLine($"The total sum is: {sum}");
    }
}