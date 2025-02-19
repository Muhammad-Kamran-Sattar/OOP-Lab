class Program
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nBook Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Search Book by Title");
            Console.WriteLine("3. Search Book by ISBN");
            Console.WriteLine("4. Update Stock");
            Console.WriteLine("5. Display All Books");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice)) continue;

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    SearchByTitle();
                    break;
                case 3:
                    SearchByISBN();
                    break;
                case 4:
                    UpdateStock();
                    break;
                case 5:
                    DisplayAllBooks();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Number of Authors (max 4): ");
        int authorCount = Math.Min(4, int.Parse(Console.ReadLine()));
        string[] authors = new string[authorCount];
        for (int i = 0; i < authorCount; i++)
        {
            Console.Write("Enter Author " + (i + 1) + ": ");
            authors[i] = Console.ReadLine();
        }

        Console.Write("Enter Publisher: ");
        string publisher = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter Stock: ");
        int stock = int.Parse(Console.ReadLine());

        books.Add(new Book(title, authors, publisher, isbn, price, stock));
        Console.WriteLine("Book added successfully!");
    }

    static void SearchByTitle()
    {
        Console.Write("Enter Title to search: ");
        string title = Console.ReadLine();
        foreach (var book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                book.DisplayInfo();
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    static void SearchByISBN()
    {
        Console.Write("Enter ISBN to search: ");
        string isbn = Console.ReadLine();
        foreach (var book in books)
        {
            if (book.ISBN == isbn)
            {
                book.DisplayInfo();
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    static void UpdateStock()
    {
        Console.Write("Enter ISBN of the book to update stock: ");
        string isbn = Console.ReadLine();
        foreach (var book in books)
        {
            if (book.ISBN == isbn)
            {
                Console.Write("Enter new stock quantity: ");
                book.Stock = int.Parse(Console.ReadLine());
                Console.WriteLine("Stock updated successfully!");
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    static void DisplayAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }
        foreach (var book in books)
        {
            book.DisplayInfo();
            Console.WriteLine("----------------------");
        }
    }
}
