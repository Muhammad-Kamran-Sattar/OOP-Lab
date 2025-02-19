using POS.cs;

internal class Program
{
    private static void Main(string[] args)
    {
        dog myDog = new dog();
        myDog.Name = "Buddy";
        myDog.Age = 3;
        myDog.Bark();
        myDog.Eat("Dog food");
        int humanYears = myDog.ConvertToHumanYears();
        Console.WriteLine($"{myDog.Name}'s age in human years {humanYears}");
    }
}