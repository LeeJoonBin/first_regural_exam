namespace _1차정규평가_이준빈;

public class Armor : Item
{
    public Armor(string name, string description, int prise, ItemCategory category) : base(name, description, prise, category)
    { }

    public override int CalculatePrice(int count)
    {
        int price = count * Prise;
        return price;
    }
}