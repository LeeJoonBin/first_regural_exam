namespace _1차정규평가_이준빈;
// 할인 가격 적용예정
public class SwiftnessPotion : Item
{
    public SwiftnessPotion() : base("민첩포션", "Potion", 300)
    {
    }

    public override int CalculatePrice(int count)
    {
        if (count >= POTION_DISCOUNT_RATE)
        {
            DiscountPrice(count);
        }
        int price = count * Prise;
        return price;
    }
    
}