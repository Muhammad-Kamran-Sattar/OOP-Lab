using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public string Publisher { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public Book(string title, string[] authors, string publisher, string isbn, double price, int stock)
    {
        Title = title;
        Authors = authors;
        Publisher = publisher;
        ISBN = isbn;
        Price = price;
        Stock = stock;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Authors: " + string.Join(", ", Authors));
        Console.WriteLine("Publisher: " + Publisher);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Price: $" + Price);
        Console.WriteLine("Stock: " + Stock);
    }
}

