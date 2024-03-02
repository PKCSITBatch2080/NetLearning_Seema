public interface IDiscountable
{
    decimal GetDiscountRate();// returns discount rate as percentage
    decimal ApplyDiscount(decimal originalPrice);// calculate the discounted Price 
}
