using System.Runtime.InteropServices.Marshalling;
using Cal;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        int Options;
        Console.WriteLine("Main menu");
        Console.WriteLine("1 for add");
        Console.WriteLine("2 for sub");
        Console.WriteLine("3 for mul");
        Console.WriteLine("4 for div");
        Console.WriteLine("Your option");
        Options = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        float num1;
        float num2;
       while (Options!=5)
       { 
        Console.WriteLine("Enter the num 1.");
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the num 2.");
        num2 = float.Parse(Console.ReadLine());
        Calculator s = new Calculator(num1, num2);
        float x = 0;

         
        if (Options == 1)
        {
            x = s.add();
            Console.WriteLine($"Sum is {x}");
                Options = Convert.ToInt32(Console.ReadLine());
        }
        else if (Options == 2) {
            x = s.sub();
            Console.WriteLine($"Sub is {x}");
                Options = Convert.ToInt32(Console.ReadLine());
        }
        else if (Options == 3)
        {
            x = s.mul();
            Console.WriteLine($"Mul is {x}");
                Options= Convert.ToInt32(Console.ReadLine());

        }
        else if (Options == 4)
        {
            x = s.div();
            Console.WriteLine($"Div is {x}");
                Options= Convert.ToInt32(Console.ReadLine());   
        }

    }
        
    }
}