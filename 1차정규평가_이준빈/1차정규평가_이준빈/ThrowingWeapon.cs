namespace _1차정규평가_이준빈;
// 할일 가격 적용 예정
public class ThrowingWeapon : Item
{
    public ThrowingWeapon(string name, string description, int prise) : base(name, description, prise)
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