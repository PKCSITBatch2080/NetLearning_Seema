public class SpecialEditionBook : Book
{
    public SpecialEditionBook(string title, decimal price, decimal discountRate)
        : base(title, price, discountRate)
    {
    }

    public override string GetBookCategory()
    {
        return "Special Edition";
    }
}
