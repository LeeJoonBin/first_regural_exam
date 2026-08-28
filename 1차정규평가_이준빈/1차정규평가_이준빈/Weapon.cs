namespace _1차정규평가_이준빈;

public class Weapon : Item
{
    public Weapon(string name, string description, int prise, ItemCategory category) : base(name, description, prise, category)
    { }
    
    public override int CalculatePrice(int count)
    {
        int price = count * Prise;
        return price;
    }
}