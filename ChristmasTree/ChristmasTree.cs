namespace ChristmasTree
{
    internal class ChristmasTree
    {
        const int ROW_LENGTH = 15;
        const int MARGIN = 7;

        static void Main(string[] args)
        {
            int rows = 8;
            
            for (int i = 0; i < rows; i++)
            {
                int count = MARGIN - i + 1;
                for (int j = 0; j < count; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < ROW_LENGTH - (count * 2); j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write("*");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}