using System.Diagnostics;

namespace ChristmasTree
{
    internal class ChristmasTree
    {
        const int ROW_LENGTH = 15;
        const int MARGIN = 7;

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int rows = 8;
            bool redraw = true;
            bool red = true;
            sw.Start();

            while (true)
            {
                //we want the tree to blink in alternating colours, but not too fast...
                if (sw.ElapsedMilliseconds % 1000 == 0)
                {
                    Console.Clear();
                    redraw = true;
                    red = !red;
                }

                //when the stop watch have run, redraw the tree
                if (redraw)
                {
                    // draw the tree one row at a time
                    for (int i = 0; i < rows; i++)
                    {
                        int count = MARGIN - i + 1;
                        //we start by drawing the empty space
                        for (int j = 0; j < count; j++)
                        {
                            Console.Write(" ");
                        }
                        //then we draw the tree
                        for (int j = 0; j < ROW_LENGTH - (count * 2); j++)
                        {
                            // first we put a star in the top of the tree
                            if (i == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("*");
                            }
                            else if (i % 2 == 0) //if we're on an even row
                            {
                                //if we're on an uneven branch, we want to see the tree
                                if (j % 2 == 0)
                                {
                                    // the tree is green
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    // if we're on an even branch, we want decorations
                                    if (red)
                                    {
                                        // sometimes lights are red
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        // sometimes the lights are blue
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                    }
                                }
                                // we draw something to make sure that we can see those pretty colours.
                                Console.Write("*");
                            }
                            else //if we're on an uneven row, but not the first row
                            {
                                // we don't want any shinies, just that nice green tree
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("*");
                            }
                        }
                        //go to a new line
                        Console.WriteLine();
                    }
                    //don't redraw the tree!
                    redraw = false;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}