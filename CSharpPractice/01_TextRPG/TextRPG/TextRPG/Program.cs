namespace TextRPG
{
    class Program
    {
        static void displayOption()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");
        }

        static void Main(string[] args)
        {
            bool isPlaying = true;
            int select = 0;

            displayOption();

            while (isPlaying)
            {
                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        isPlaying = false;
                        break;
                    case 2:
                        isPlaying = false;
                        break;
                    case 3:
                        isPlaying = false;
                        break;
                    default:
                        displayOption();
                        break;
                }
            }
        }
    }
}
