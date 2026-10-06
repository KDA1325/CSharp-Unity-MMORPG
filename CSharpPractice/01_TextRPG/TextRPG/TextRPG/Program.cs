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

        // 구조체 struct - 다양한 타입의 데이터를 하나로 묶어서 관리할 수 있는 타입
        struct Player
        {
            public int hp;
            public int attack;
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }
        
        struct Monster
        {
            public int hp;
            public int attack;
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

            DisplayOption();

            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
                default:
                    //DisplayOption();
                    break;
            }

            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            switch(choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0; 
                    break;
            }
        }

        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();

            // 1~3 사이의 랜덤 정수 생성
            int randMonster = rand.Next(1, 4); 

            switch(randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다!");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다!");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다!");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }

        static void Fight(ref Player player, ref Monster monster)
        {
            // 이 안에서 그냥 player, monster 멤버 변수를 아무리 수정해도 Main 함수에 있는 원본 player, monster에는 영향을 주지 않음 
            // -> 파라미터에 ref 키워드를 붙여서 원본을 직접 수정
            while (true)
            {
                // 플레이어 공격
                monster.hp -= player.attack;

                if(monster.hp <= 0)
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine($"남은 체력: {player.hp}");
                    break;
                }

                // 몬스터 반격
                player.hp -= monster.attack;

                if(player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다!");
                    break;
                }
            }
        }

        static void EnterField(ref Player player)
        {
            while(true)
            {
                Console.WriteLine("필드에 접속했습니다.");

                Monster monster;

                // 랜덤으로 1-3 몬스터 중 하나를 리스폰 
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투 모드로 돌입");
                Console.WriteLine("[2] 일정 확률로 마을로 도망");

                string input = Console.ReadLine();

                if(input == "1")
                {
                    Fight(ref player, ref monster);
                }
                else if(input == "2")
                {
                    // 도망 확률 33%
                    Random rand = new Random();

                    // 0~100 사이의 랜덤 정수 생성
                    int randVal = rand.Next(0, 101);

                    // 33% 안에 들어옴
                    if(randVal <= 33)
                    {
                        Console.WriteLine("도망치는 데 성공했습니다!");
                        break;
                    }
                    else
                    {
                        Fight(ref player, ref monster);
                    }
                }
            }
        }

        static void EnterGame(ref Player player)
        {
            while(true)
            {
                Console.WriteLine("마을에 접속했습니다!");
                Console.WriteLine("[1] 필드로 간다");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        EnterField(ref player);
                        Console.WriteLine("필드로 이동합니다.");
                        break;
                    case "2":
                        // EnterGame() 함수를 종료하고 Main()으로 돌아감
                        return; 
                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 선택해주세요.");
                        EnterGame(ref player);
                        break;
                }

            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ChooseClass();

                if (choice != ClassType.None)
                {
                    // 캐릭터 생성
                    Player player;
                    
                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP{player.hp} Attack{player.attack}");

                    // 필드로 가서 몬스터와 전투
                    EnterGame(ref player);
                }
            }
        }
    }
}
