﻿namespace 리스트와_링크드리스트_기본학습
/*
과제 1. 동적 인벤토리 구현하기
다음의 조건을 충족하는 인벤토리 시스템을 구현하시오
프로그램 시작 시 인벤토리는 빈 상태에서 시작한다.
프로그램이 구동되는 동안 입력마다 콘솔에 지속적으로 인벤토리의 상태를 표시한다
인벤토리는 최대 9개의 아이템을 가질 수 있다.
인벤토리는 빈칸 없이 앞부터 채워서 가진다
숫자키 0을 누르면 랜덤으로 아이템의 종류를 획득하고 인벤토리에 추가한다
숫자키 1~9를 누르면 해당하는 숫자의 아이템을 제거한다
구현 클래스
Inventory
Item
Potion : Item
Weapon : Item
Armor : Item
Accessory : Item
Food : Item
*/
{
    internal class Program
    {
        public class Inventory
        {
            private List<Item> items;
            private Item[] itemTypes;

            public Inventory()
            {
                items = new List<Item>();
                itemTypes = new Item[]
                {
                    new Potion("포션"),
                    new Weapon("무기"),
                    new Armor("방어구"),
                    new Food("음식")
                };
            }

            public void InventoryState()
            {
                Console.WriteLine("현재 인벤토리 목록: ");
                for (int i = 0; i < 9; i++)
                {
                    if (i < items.Count)
                        Console.WriteLine($"{i + 1}: {items[i]}");
                    else
                        Console.WriteLine($"{i + 1}: 없음 ");
                }
                Console.WriteLine("---------------------------------------------");
            }

            public void AddInventoryItem(Item item)
            {
                if (items.Count < 9)
                {
                    items.Add(item);
                    Console.WriteLine($"아이템추가: {item}");
                    InventoryState();
                }
                else
                {
                    Console.WriteLine("인벤토리 크기가 9가 넘었습니다.");
                }
            }

            public void RemoveInventoryItem(int index)
            {
                if (index > 0 && index <= items.Count)
                {
                    Console.WriteLine($"{items[index - 1]} 아이템이 제거되었습니다.");
                    items.RemoveAt(index - 1);
                    InventoryState();
                }
                else
                {
                    Console.WriteLine("잘못된 인덱스 입니다.");
                }
            }

            public Item GetRandomItem(Random random)
            {
                int ran = random.Next(0, itemTypes.Length);
                return itemTypes[ran];
            }
        }




        public class Item //출력시 아이템 부분이 이상하게 출력되는데 이유가 무엇일까요...ㅠㅠㅠ
        {
            public string name;
            public Item(string name)
            {
                this.name = name;
            }
        }


        public class Potion : Item
        {
            public Potion(string name) : base(name)
            {
                this.name = name;
            }
        }

        public class Weapon : Item
        {
            public Weapon(string name) : base(name)
            {
                this.name = name;
            }
        }

        public class Armor : Item
        {
            public Armor(string name) : base(name)
            {
                this.name = name;
            }
        }

        public class Food : Item
        {
            public Food(string name) : base(name)
            {
                this.name = name;
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            Inventory inventory = new Inventory();
            Item item;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("인벤토리 시스템입니다.");
            Console.WriteLine("0 입력: 랜덤 아이템 추가");
            Console.WriteLine("1-9 입력: 해당 번호의 아이템 제거");
            Console.WriteLine("--------------------------------------");

            while (true)
            {
                Console.Write("숫자를 입력해주세요: ");
                string input = Console.ReadLine();
                bool correct = int.TryParse(input, out int index);

                if (correct == false)
                {
                    Console.WriteLine("숫자를 입력해주세요");
                }
                else if (index == 0)
                {
                    inventory.AddInventoryItem(inventory.GetRandomItem(random));
                }
                else if (index > 0 && index < 10)
                {
                    inventory.RemoveInventoryItem(index);
                }
                else
                {
                    Console.WriteLine("0이나 1~9의 숫자를 입력해주세요");
                }
            }
        }
    }
}

