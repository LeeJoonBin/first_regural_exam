namespace _1차정규평가_이준빈;

public class Manapotion : Potion
{
    public Manapotion() : base("마나포션", "Potion", 100)
    {
    }
    public override int CalculatePrice(int count)
    {
        int price = count * Prise;
        return price;
    }
}