public class SpecialEditionBook : Book
{
    // Static field
    public static int SpecialEditionExtraPages = 50;

    // Constructor
    public SpecialEditionBook(string title, decimal price, decimal discountRate)
        : base(title, price, discountRate)
    {
    }

    // Overriding the DisplayInfo method from StoreItem to include special edition info
    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}, Special Edition";
    }

    // Overriding the GetBookCategory method from Book
    public override string GetBookCategory()
    {
        return "Special Edition";
    }

    // Unique method for SpecialEditionBook
    public string GetExtraFeatures()
    {
        return "Includes exclusive content and artwork.";
    }
}
