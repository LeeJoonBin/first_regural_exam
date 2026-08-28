namespace _1차정규평가_이준빈;
// 추상클래스 2 아이템메뉴
public abstract class ItemMenu
{
    protected string Name;
    protected string Description;
    protected int Prise;

    protected ItemMenu(string name, string description, int prise)
    {
        Name = name;
        Description = description;
        Prise = prise;
    }
    
}