namespace _1차정규평가_이준빈;
// 추상 클래스 1 포션
public abstract class Potion
{
    protected const int MINQUANTITY = 10;
    protected const float DISCOUNT_RATE = 0.40f;
    
    protected string Name { get; private set; }
    protected string Description { get; private set; }
    protected int Prise  { get; private set; }
    
    protected Potion(string name, string description, int prise)
    {
        Name = name;
        Description = description;
        Prise = prise;
    }
    
    public abstract int CalculatePrice(int count);
    public virtual int DiscountPrice(int count)
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