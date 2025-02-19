class Member
{
    public string Name { get; set; }
    public int MemberID { get; set; }
    public List<string> BooksBought { get; set; }
    public int NumBooksBought { get; private set; }
    public double MoneyInBank { get; set; }
    public double AmountSpent { get; private set; }

    public Member(string name, int memberId, double moneyInBank)
    {
        Name = name;
        MemberID = memberId;
        MoneyInBank = moneyInBank;
        BooksBought = new List<string>();
        NumBooksBought = 0;
        AmountSpent = 0;
    }

    public void BuyBook(Book book, int quantity)
    {
        double totalCost = book.Price * quantity;
        if (MemberID != 0)
        {
            totalCost *= 0.95; // 5% discount for members
            if (NumBooksBought % 10 == 0 && NumBooksBought > 0)
            {
                totalCost -= AmountSpent / 10; // Discount on every 11th book
                AmountSpent = 0;
            }
        }

        if (MoneyInBank >= totalCost && book.Stock >= quantity)
        {
            BooksBought.Add(book.Title);
            NumBooksBought += quantity;
            AmountSpent += totalCost;
            MoneyInBank -= totalCost;
            book.Stock -= quantity;
            Console.WriteLine($"{Name} purchased {quantity} copies of {book.Title} for ${totalCost}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or stock!");
        }
    }
}