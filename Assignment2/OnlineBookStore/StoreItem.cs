public abstract class StoreItem
{
    protected decimal originalPrice;

    protected StoreItem(decimal price)
    {
        originalPrice = price;
    }

    public decimal OriginalPrice => originalPrice;

    public abstract string DisplayInfo();

    public abstract decimal GetDiscountRate();
}
