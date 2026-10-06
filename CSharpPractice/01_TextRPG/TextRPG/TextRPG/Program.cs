namespace TextRPG
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        static void DisplayOption()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");
        }

        static ClassType ChooseClass()
        {
            ClassType choice = ClassType.None;

            int select = 0;

            select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    choice = ClassType.Knight;
                    break;
                case 2:
                    choice = ClassType.Archer;
                    break;
                case 3:
                    choice = ClassType.Mage;
                    break;
                default:
                    displayOption();
                    break;
            }

            return choice;
        }

        static void CreatePlayer(out int hp, out int attack)
        {

        }
        static void Main(string[] args)
        {
            DisplayOption();

            while (true)
            {
                ClassType choice = ChooseClass();

                if (choice != ClassType.None)
                {
                    // 캐릭터 생성
                    int hp;
                    int attack;
                    
                    // 기사(100/10) 궁수(75/12) 법사(50/15)

                    CreatePlayer(out hp, out attack);

                    // 필드로 가서 몬스터와 전투
                    break;
                }
            }
        }
    }
}
