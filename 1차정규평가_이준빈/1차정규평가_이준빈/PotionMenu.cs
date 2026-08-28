namespace _1차정규평가_이준빈;
// 추상 클래스 1 포션
public abstract class PotionMenu
{
    protected const int MINQUANTITY = 10;
    protected const float DISCOUNT_RATE = 0.40f;
    
    protected string Name;
    protected string Description;
    protected int Prise;
    
    protected PotionMenu(string name, string description, int prise)
    {
        Name = name;
        Description = description;
        Prise = prise;
    }
    
    protected virtual int Discount(int count)
    {
        int remain;
        if (count >= MINQUANTITY)
        {
            
            remain = (int)(Prise * DISCOUNT_RATE);
            return remain;
        }
        return 0;
    }
}