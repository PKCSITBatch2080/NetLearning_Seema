public interface IShoppingCart
{
    int GetItemCount();
    void AddItem( string productId, int quantity);
    void RemoveItem(string productId);
}