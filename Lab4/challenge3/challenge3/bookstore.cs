
class Bookstore
{
    private List<Book> inventory = new List<Book>();
    private List<Member> members = new List<Member>();
    private double totalSales = 0;
    private int membershipCount = 0;

    public void AddBook(Book book) => inventory.Add(book);
    public void AddMember(Member member)
    {
        members.Add(member);
        if (member.MemberID != 0)
        {
            membershipCount++;
            totalSales += 10;
        }
    }

    public Book SearchBook(string title) => inventory.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    public Book SearchBookByISBN(string isbn) => inventory.Find(b => b.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
    public Member SearchMember(int memberId) => members.Find(m => m.MemberID == memberId);

    public void PurchaseBook(int memberId, string title, int quantity)
    {
        Member member = SearchMember(memberId) ?? new Member("Guest", 0, double.MaxValue);
        Book book = SearchBook(title);
        if (book != null)
        {
            member.BuyBook(book, quantity);
            totalSales += book.Price * quantity;
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Total Sales: ${totalSales}\nTotal Members: {membershipCount}\nMembership Fees Collected: ${membershipCount * 10}");
    }
}
