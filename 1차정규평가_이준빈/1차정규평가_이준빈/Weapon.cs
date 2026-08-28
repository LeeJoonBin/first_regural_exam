namespace _1차정규평가_이준빈;

public class Weapon : Item
{
    public Weapon() : base("검", "Item", 1000)
    { }
    
    public override int CalculatePrice(int count)
    {
        int price = count * Prise;
        return price;
    }
}