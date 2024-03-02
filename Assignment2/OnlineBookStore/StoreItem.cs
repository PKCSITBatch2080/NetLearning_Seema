public abstract class StoreItem
{
    // Field
    protected decimal originalPrice;

    // Constructor to initialize the original price
    protected StoreItem(decimal price)
    {
        originalPrice = price;
    }

    // Read-only property to get the original price
    public decimal OriginalPrice
    {
        get { return originalPrice; }
    }

    // Abstract method to display information about the item
    public abstract string DisplayInfo();

    // Abstract method to get the item's discount rate (assuming every item could have a discount rate)
    public abstract decimal GetDiscountRate();
}
