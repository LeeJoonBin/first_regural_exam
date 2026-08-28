namespace _1차정규평가_이준빈;
// 할인 가격 적용예정
public class SwiftnessPotion : Item
{
    public SwiftnessPotion(string name, string description, int prise, ItemCategory category) : base(name, description, prise, category)
    {
    }

    public override int CalculatePrice(int count)
    {
        if (count >= POTION_MINIMUM)
        {
            DiscountPrice(count);
        }
        int price = count * Prise;
        return price;
    }
    
}