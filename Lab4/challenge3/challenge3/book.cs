class Book
{
    public string Title { get; set; }
    public List<string> Authors { get; set; }
    public string Publisher { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int Year { get; set; }

    public Book(string title, List<string> authors, string publisher, string isbn, double price, int stock, int year)
    {
        Title = title;
        Authors = authors;
        Publisher = publisher;
        ISBN = isbn;
        Price = price;
        Stock = stock;
        Year = year;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthors: {string.Join(", ", Authors)}\nPublisher: {Publisher}\nISBN: {ISBN}\nPrice: ${Price}\nStock: {Stock}\nYear: {Year}");
    }
}
