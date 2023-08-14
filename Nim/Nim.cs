﻿using System.Formats.Asn1;
using System.Security;
using System.Text;

namespace Nim
{
    internal class Nim
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int matches;
            int taken;
            bool player = true;
            Random rand = new Random();
            ConsoleKey key = new ConsoleKey();

            while (true)
            {
                matches = 7;
                Console.Clear();
                Console.WriteLine("Hej, skal vi spille Nim?");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Enter)
                {
                    while (matches > 1)
                    {
                        StringBuilder message = new StringBuilder();
                        Console.WriteLine($"Der ligger {matches} tændstikker på bordet");
                        if (player)
                        {
                            message.Append("Det er din tur, du må tage op til ");
                            if (matches > 3)
                            {
                                message.Append('3');
                            }
                            else
                            {
                                message.Append(matches - 1);
                            }
                            message.Append(" tændstikker!");
                            Console.WriteLine(message.ToString());
                            while (true)
                            {
                                try
                                {
                                    taken = int.Parse(Console.ReadLine());
                                    if (taken > matches || taken > 3)
                                    {
                                        throw new Exception();
                                    }
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Du skal tage et antal tændstikker, prøv igen!");
                                }
                            }
                            matches -= taken;
                            if(matches == 1)
                            {
                                Console.WriteLine("Tillykke! Du har vundet spillet!");
                                break;
                            }
                            player = false;
                        }
                        else
                        {
                            try
                            {
                                if (matches > 3)
                                {
                                    taken = rand.Next(1, 4);
                                }
                                else
                                {
                                    taken = rand.Next(1, matches - 1);
                                }
                                matches -= taken;
                                Console.WriteLine($"computeren tager {taken} tændstikker!");
                                player = true;
                            }
                            catch
                            {
                                Console.WriteLine("Tillykke! Du har vundet spillet");
                            }
                            if (matches == 1)
                            {
                                Console.WriteLine("Du har tabt spillet!");
                            }
                        }
                    }
                }
                key = Console.ReadKey().Key;
            }
        }
    }
}