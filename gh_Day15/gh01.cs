namespace gh_Day15
{
    /********************************************************************************************************************************

      *  과제 1. 팩토리 메소드 패턴 활용하기
     
         이번 강의에선 팩토리 메소드 패턴의 예시로, 게임에 필요한 오브젝트를 생성하는 코드를 다루었었습니다.
         해당 개념을 참고하여, ItemFactory 클래스를 만들고, 팩토리 메소드를 통해서 다양한 Item을 생성해보세요.
     
      1. Item은 ItemFactory를 통해서 생성하도록 한다.
      2. ItemFactory는 Create(ItemType type) 함수를 가진다.
      3. ItemType은 열거형으로 Potion, Weapon, Armor, Food 항목을 가진다
      4. ItemFactory는 Create 함수에 매개변수로 받은 열거형의 유형을 기준으로 각 항목에 맞는 아이템 인스턴스를 생성하여 준다.
     
     ********************************************************************************************************************************/

    public enum ItemType { Potion, Weapon, Armor, Food }; // 열거형 ItemType 생성

    // 기본형이 될 Item 클래스 생성
    public class Item
    {
        public string name;
        public int have;
        public string explain;
    }

    // 팩토리 메소드 패턴 사용
    public class ItemFactory
    {
        public static Item Create(ItemType type)
        {
            if (type == ItemType.Potion)
            {
                Item potion = new Item();
                potion.name = "오크의 조합약";
                potion.have = 5;
                potion.explain = "오크 수제의 의약품. 뭘 으깨 만든건지 묘하게 구린내가 난다... 그래도 약효는 확실하다.";
                return potion;
            }
            else if (type == ItemType.Weapon)
            {
                Item weapon = new Item();
                weapon.name = "검";
                weapon.have = 1;
                weapon.explain = "평범한 검. 가끔 뭔가 달그락 거린다.";
                return weapon;
            }
            else if (type == ItemType.Armor)
            {
                Item armor = new Item();
                armor.name = "개구리 수트";
                armor.have = 3;
                armor.explain = "거대 개구리의 가죽을 가공하여 만든 수트. 아직 건조 과정을 거치지 않아, 입으면 개구리에게 먹힌 것 같은 느낌을 체험할 수 있다.";
                return armor;
            }
            else if (type == ItemType.Food)
            {
                Item food = new Item();
                food.name = "동전벌레 튀김";
                food.have = 30;
                food.explain = "작은 물고기 같은 맛이 난다. 튀긴 지 얼마 되지 않아 바삭하고, 조금 달작지근한 맛이 난다.";
                return food;
            }
            else
            {
                Console.WriteLine();
                return null;
            }
        }
    }

    // 출력
    internal class gh01
    {
        static void Main(string[] args)
        {
            Item potion = ItemFactory.Create(ItemType.Potion);
            Item weapon = ItemFactory.Create(ItemType.Weapon);
            Item armor = ItemFactory.Create(ItemType.Armor);
            Item food = ItemFactory.Create(ItemType.Food);

            Console.WriteLine("다음 보기에서 아이템을 선택하세요.");
            Console.WriteLine();
            Console.WriteLine($"1. {potion.name}");
            Console.WriteLine($"2. {weapon.name}");
            Console.WriteLine($"3. {armor.name}");
            Console.WriteLine($"4. {food.name}");
            Console.WriteLine("===================================");
            Console.Write("입력 : ");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.WriteLine($"{potion.name} : {potion.have}개 소지 | {potion.explain}");
                    break;
                case 2:
                    Console.WriteLine($"{weapon.name} : {weapon.have}개 소지 | {weapon.explain}");
                    break;         
                case 3:            
                    Console.WriteLine($"{armor.name} : {armor.have}개 소지 | {armor.explain}");
                    break;         
                case 4:            
                    Console.WriteLine($"{food.name} : {food.have}개 소지 | {food.explain}");
                    break;
            }


        }
    }
}
