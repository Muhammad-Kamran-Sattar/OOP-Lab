internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[3];
        for (int idx = 0; idx < 3; idx++)
        {
            Console.WriteLine($"Enter the numbers {idx} ");
            numbers[idx] = Convert.ToInt32(Console.ReadLine());
        }
        int largest = -1;
        for (int idx = 0; idx < numbers.Length; idx++)
        {
            if (numbers[idx] > largest)
            {
                largest = numbers[idx];

            }
        }
        Console.WriteLine($"Largest is:{largest}");

    }
}