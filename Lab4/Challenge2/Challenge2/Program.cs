

class Program
{
    static void Main()
    {
        Console.Write("Enter member name: ");
        string name = Console.ReadLine();
        Console.Write("Enter member ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter initial bank balance: ");
        double balance = double.Parse(Console.ReadLine());

        Member member = new Member(name, id, balance);

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Buy a book");
            Console.WriteLine("2. Show details");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter book name: ");
                    string bookName = Console.ReadLine();
                    Console.Write("Enter book price: ");
                    double price = double.Parse(Console.ReadLine());
                    member.BuyBook(bookName, price);
                    break;
                case 2:
                    member.ShowDetails();
                    break;
                case 3:
                    Console.WriteLine("Exiting... Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
