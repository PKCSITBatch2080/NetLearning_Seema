public class Book : StoreItem, IDiscountable
{
    public string Title { get; set; }
    private decimal discountRate;
    public Book (string title, decimal price, decimal discountRate) : base(price)
    {
        Title = title;
        this.discountRate = discountRate;
    }

    // Implementing the abstract DisplayInfo method
     public override string DisplayInfo()
     {
        return $"Title: {Title}, Original Price: ${OriginalPrice}";
     }

     //Implementing GetDiscountRate from both StoreItem and IDiscountable

     public override decimal GetDiscountRate()
     {
        return discountRate;
     }

    public decimal ApplyDiscount(decimal originalPrice)
    {
        return originalPrice * (1 - (discountRate / 100));
    }

    //New virtual method to demonstrate overriding
     public virtual string GetBookCategory()
    {
        return "General";
    }
}