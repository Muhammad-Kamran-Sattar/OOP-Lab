internal class Program
{
    private static void Main(string[] args)
    {
        int age=0,price=0,total=0,washing=0;
        Console.WriteLine("Enter the age:");
        age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the price of unit toy:");
        price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the price of machine:");
        washing = Convert.ToInt32(Console.ReadLine());
        int num = 0;
        for (int i = 0; i < age; i++)
        {

            if (i % 2 == 0)
            {
                num = num + 10;
                total = total+num ;
                total = total - 1;
            }
            if(i%2!=0)
            {
                total += price;
            }

        }
        int rem = 0;
        if (total > washing)
        {
            
            rem = total - washing;
            Console.WriteLine($"Yes:{rem}");
        }
        if(total<washing)
        {
            
            rem = washing - total ;
            Console.WriteLine($"No:{rem}");
        }
    }
}