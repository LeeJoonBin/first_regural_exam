namespace _1차정규평가_이준빈;
// 할일 가격 적용 예정
public class ThrowingWeapon : Item
{
    public ThrowingWeapon(): base("투척무기", "Item", 300)
    {}
    
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