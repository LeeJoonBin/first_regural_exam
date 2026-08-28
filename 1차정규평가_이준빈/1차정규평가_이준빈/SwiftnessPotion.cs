namespace _1차정규평가_이준빈;
// 할인 가격 적용예정
public class SwiftnessPotion : Potion
{
    public string InfoDiscount = ($"할인 적용 상품: {MINQUANTITY}구매 시 10%할인");

    public SwiftnessPotion() : base("민첩포션", "Potion", 300)
    {
    }

    public override int CalculatePrice(int count)
    {
        if (count >= MINQUANTITY)
        {
            DiscountPrice(count);
        }
        int price = count * Prise;
        return price;
    }
    
}