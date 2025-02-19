using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        Bookstore store = new Bookstore();
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Search a Book by Title");
            Console.WriteLine("3. Search a Book by ISBN");
            Console.WriteLine("4. Add a Member");
            Console.WriteLine("5. Purchase a Book");
            Console.WriteLine("6. Display Stats");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author(s) (comma-separated): ");
                    List<string> authors = new List<string>(Console.ReadLine().Split(','));
                    Console.Write("Enter publisher: ");
                    string publisher = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Enter price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Enter stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    Console.Write("Enter year of publication: ");
                    int year = int.Parse(Console.ReadLine());
                    store.AddBook(new Book(title, authors, publisher, isbn, price, stock, year));
                    break;
                case 2:
                    Console.Write("Enter book title: ");
                    Book book = store.SearchBook(Console.ReadLine());
                    book?.DisplayBookInfo();
                    break;
                case 3:
                    Console.Write("Enter ISBN: ");
                    Book bookByISBN = store.SearchBookByISBN(Console.ReadLine());
                    bookByISBN?.DisplayBookInfo();
                    break;
                case 4:
                    Console.Write("Enter member name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter member ID (0 for non-member): ");
                    int memberId = int.Parse(Console.ReadLine());
                    Console.Write("Enter initial bank balance: ");
                    double balance = double.Parse(Console.ReadLine());
                    store.AddMember(new Member(name, memberId, balance));
                    break;
                case 5:
                    Console.Write("Enter member ID (0 for non-member): ");
                    int buyerId = int.Parse(Console.ReadLine());
                    Console.Write("Enter book title: ");
                    string bookTitle = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    store.PurchaseBook(buyerId, bookTitle, quantity);
                    break;
                case 6:
                    store.DisplayStats();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
