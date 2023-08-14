using System.Diagnostics;

namespace Loops
{
    internal class HeldOgLotto
    {
        static void Main(string[] args)
        {
            int[] tal = new int[7];
            Random random = new Random();
            Stopwatch sw = new Stopwatch();
            ConsoleKey key = new();

            while (true)
            {
                Console.WriteLine("Vil du skrive lottotalene ud?");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Enter)
                {
                    Console.Write("Tal:");
                    while (tal.Length != tal.Distinct().Count())
                    {
                        for (int i = 0; i < tal.Length; i++)
                        {
                            tal[i] = random.Next(1, 37);
                        }
                        tal.OrderBy(x => x);
                    }

                    sw.Start();
                    for (int i = 0; i < tal.Length; i++)
                    {
                        while (true)
                        {
                            if (sw.ElapsedMilliseconds > 1999)
                            {
                                if (i == tal.Length - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(tal[i]);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(tal[i] + ", ");
                                }

                                sw.Restart();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}