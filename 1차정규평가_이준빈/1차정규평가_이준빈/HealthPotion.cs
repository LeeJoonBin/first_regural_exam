namespace _1차정규평가_이준빈;

public class HealthPotion : Item
{
    public HealthPotion() : base("체력포션", "Potion", 150)
    {
    }
    public override int CalculatePrice(int count)
    {
        int price = count * Prise;
        return price;
    }
}