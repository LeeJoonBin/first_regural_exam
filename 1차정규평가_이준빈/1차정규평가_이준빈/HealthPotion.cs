namespace _1차정규평가_이준빈;

public class HealthPotion : Item
{
    public HealthPotion(string name, string description, int prise) : base(name, description, prise)
    {
    }
    public override int CalculatePrice(int count)
    {
        int price = count * Prise;
        return price;
    }
}