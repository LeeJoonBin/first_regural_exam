namespace _1차정규평가_이준빈;
using System;
using System.Collections.Generic;

public class Program
{
    public const string STORE_NAME = "정규시험 상점";
    void Main(string[] args)
    {
        Console.WriteLine($"{STORE_NAME} 키오스크");
        List<Item> itemList = new List<Item>(6);

        Weapon weapon = new Weapon("철검", "정가", 1000);
        Armor armor = new Armor("가죽 갑옷", "정가", 500);
        ThrowingWeapon throwingWeapon = new ThrowingWeapon("투척무기", "3개 구매 / 10% 할인", 400);
        HealthPotion healthPotion = new HealthPotion("체력 물약", "정가", 50);
        Manapotion manapotion = new Manapotion("마나 포션", "정가", 50);
        SwiftnessPotion swiftnessPotion = new SwiftnessPotion("민첩 포션", "5개 구매 / 10% 할인", 100);
        

    }
}