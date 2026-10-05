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

        static void displayOption()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");
        }

        static ClassType chooseClass()
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

        static void Main(string[] args)
        {
            displayOption();

            while (true)
            {
                ClassType choice = chooseClass();

                if (choice != ClassType.None)
                {
                    break;
                }
            }
        }
    }
}
