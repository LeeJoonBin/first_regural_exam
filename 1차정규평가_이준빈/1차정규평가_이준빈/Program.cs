// https://github.com/LeeJoonBin/first_regural_exam
namespace _1차정규평가_이준빈;
using System;
using System.Collections.Generic;

public class Program
{
    public const string STORE_NAME = "정규시험 상점";

    static void Main(string[] args)
    {
        // 아이템 목록
        List<Item> shopItems = new List<Item>
        {
            new Weapon("철검", "정가", 1000, ItemCategory.Weapon),
            new Armor("가죽 갑옷", "정가", 500, ItemCategory.Armor),
            new ThrowingWeapon("투척무기", "3개 구매 / 10% 할인", 400, ItemCategory.Weapon),
            new HealthPotion("체력 물약", "정가", 50, ItemCategory.Potion),
            new Manapotion("마나 포션", "정가", 50, ItemCategory.Potion),
            new SwiftnessPotion("민첩 포션", "5개 구매 / 10% 할인", 100, ItemCategory.Potion)
        };

        List<CartItem> invertory = new List<CartItem>();
        int totalGoldEarned = 0;
        int transactionCount = 0;

        Console.WriteLine("------------------------");
        Console.WriteLine($"{STORE_NAME} 키오스크");
        Console.WriteLine("------------------------");
        for (int i = 0; i < shopItems.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}번 {shopItems[i].Name} ({shopItems[i].ItemCategory}) {shopItems[i].Prise}골드  [{shopItems[i].Description}]");

        }

        Console.WriteLine("------------------------");
        Console.WriteLine("[장바구니]");
        Console.WriteLine();
        int currentTotal = 0;

        foreach (var slot in invertory)
        {
            int price = slot.GetTotalPrice();
            currentTotal += price;
            Console.WriteLine($"{slot.Product.Name} x {slot.Quantity} = {price}골드");
        }

        Console.WriteLine($"합계 = {currentTotal}골드");
        Console.WriteLine("------------------------");
        int choiceMenu = ConsoleInput.ReadIntInRange("1. 메뉴 담기   2. 전체 비우기   3. 결제   4. 영업 종료 번호 : ", 1, 4);


        switch (choiceMenu)
        {
            case 1:


                int number = ConsoleInput.ReadIntInRange("아이템 번호: ", 1, shopItems.Count) - 1;
                ConsoleInput.Pause();
                int amount = ConsoleInput.ReadIntAtLeast("수량을 입력하세요:", 0);
                invertory.Add(new CartItem(shopItems[number], amount));
                break;
        }
    }
}