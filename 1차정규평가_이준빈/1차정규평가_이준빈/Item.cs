namespace _1차정규평가_이준빈;
// 추상클래스 2 아이템메뉴
public abstract class Item
{
    protected const int MINQUANTITY = 3;
    protected const float DISCOUNT_RATE = 0.10f;
    
    protected string Name { get; private set; }
    protected string Description { get; private set; }
    protected int Prise { get; private set; }
    protected virtual string InfoDiscount {get; set;}

    protected Item(string name, string description, int prise)
    {
        Name = name;
        Description = description;
        Prise = prise;
    }
    
    public abstract int CalculatePrice();
    public virtual int Discount(int count)
    {
        int remain;
        if (count >= MINQUANTITY)
        {
            
            remain = (int)(Prise * DISCOUNT_RATE);
            Console.WriteLine($"{MINQUANTITY}개 이상 구매하셔 10% 할인되었습니다.");
            return remain;
        }
        return 0;
    }
    
}