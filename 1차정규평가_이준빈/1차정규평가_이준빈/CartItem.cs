namespace _1차정규평가_이준빈;

public class CartItem
{
    public Item Product { get; private set; }
    public int Quantity { get; private set; }

    public CartItem(Item product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    
    public int GetTotalPrice() => Product.CalculatePrice(Quantity);
}