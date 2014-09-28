using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public string str;
    public ConsoleColor color;
}
class FallingRocks
{
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(c);
    }

    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(str);
    }

    static void Main()
    {
        int livesCounter = 5;
        int bonus = 0;
        double speed = 300.0;
        double acceleration = 0.5;

        Console.BufferHeight = Console.WindowHeight = 50;
        Console.BufferWidth = Console.WindowWidth = 60;

        int playFieldStart = 9;
        int playFieldHeightEnd = Console.WindowHeight - 1;
        int playFieldWidthtEnd = 55;
        Random randomGenerator = new Random();

        string[] rocksSymbols = { "^", "@", "*", "++", "&", ";", "%", "$", "#", "!", "..","+++" };
        int indexSymbols;
        string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));

        //create the dwarf
        Object dwarf = new Object();
        dwarf.x = 20;
        dwarf.y = playFieldHeightEnd - 1;
        dwarf.color = ConsoleColor.Red;
        dwarf.str = "(0)";

        //PrintStringOnPosition(dwarf.x, dwarf.y, dwarf.str, dwarf.color);

        //create a list of the rocks
        List<Object> rocks = new List<Object>();

        while (true)
        {
            indexSymbols = randomGenerator.Next(0, rocksSymbols.Length);
            ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[randomGenerator.Next(0, colorNames.Length)]);

            speed += acceleration;

            if (speed > 300)
            {
                speed = 300;
            }
            bool hasCollision = false;
            bool hasBonus = false;
            {
                int chance = randomGenerator.Next(0, playFieldWidthtEnd);
                if (chance < 5)
                {
                    Object rockBonus = new Object();
                    rockBonus.x = randomGenerator.Next(0, Console.WindowHeight); ;
                    rockBonus.y = playFieldStart;
                    rockBonus.color = ConsoleColor.White;
                    rockBonus.str = "O";
                    rocks.Add(rockBonus);
                }
                else
                {
                    Object rock = new Object();
                    rock.x = randomGenerator.Next(0, Console.WindowHeight); ;
                    rock.y = playFieldStart;
                    rock.color = color;
                    rock.str = rocksSymbols[indexSymbols]; ;
                    rocks.Add(rock);
                }

            }
            //move dwarf
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playFieldWidthtEnd)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            //move the rocks 
            //create a new list and copy the old coordiantes of the rocks into the new rocks, than clear the old rocks
            List<Object> newRocks = new List<Object>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Object oldRock = rocks[i];
                Object newRock = new Object();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.str = oldRock.str;
                newRock.color = oldRock.color;
                //rocks.Remove(oldRock);

                //collision detection
                if ((newRock.y == dwarf.y && newRock.x == dwarf.x) || (newRock.y == dwarf.y && newRock.x == dwarf.x + 1)
                            || (newRock.y == dwarf.y && newRock.x == dwarf.x + 2))
                {
                    if (newRock.str == "O")
                    {
                        hasBonus = true;
                        bonus++;
                        livesCounter++;
                        if (bonus==50)
                        {
                            Console.Clear();
                            PrintStringOnPosition(20, 4, "YOU WIN!!!", ConsoleColor.White);
                            PrintStringOnPosition(15, 5, "Press [enter] to exit", ConsoleColor.White);
                            Console.ReadLine();
                            Environment.Exit(0); 
                        }
                    }
                    else
                    {
                        hasCollision = true;
                        livesCounter--;
                        speed += 50;
                        if (speed > 400)
                        {
                            speed = 400;
                        }
                        if (livesCounter <= 0)
                        {
                            Console.Clear();
                            PrintStringOnPosition(20, 4, "GAME OVER!!!", ConsoleColor.White);
                            PrintStringOnPosition(15, 5, "Press [enter] to exit", ConsoleColor.White);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                }

                if (newRock.y < playFieldHeightEnd - 1)
                {
                    newRocks.Add(newRock);
                }
            }
            rocks = newRocks;
            Console.Clear();

            if (hasCollision)
            {
                newRocks.Clear();
                PrintStringOnPosition(dwarf.x, dwarf.y, "XXX", ConsoleColor.Red);
            }
            else if (hasBonus)
            {
                PrintStringOnPosition(dwarf.x, dwarf.y, "+1", ConsoleColor.Yellow);
            }
            else
            {

                PrintStringOnPosition(dwarf.x, dwarf.y, dwarf.str, ConsoleColor.Red);
            }
            foreach (Object rock in rocks)
            {
                PrintStringOnPosition(rock.x, rock.y, rock.str, rock.color);
            }




            PrintStringOnPosition(6, 2, "-----> You are playing Falling Rocks <-----", ConsoleColor.Green);
            PrintStringOnPosition(4, 4, "Avoid the falling rock or catch O for +1 live", ConsoleColor.White);
            PrintStringOnPosition(0, 10, "-------------------------------------------------------", ConsoleColor.Red);
            PrintStringOnPosition(0, playFieldHeightEnd, "-------------------------------------------------------", ConsoleColor.Red);


            //draw scores info
            PrintStringOnPosition(20, 5, "Remaining lives : " + livesCounter, ConsoleColor.Green);
            PrintStringOnPosition(20, 6, "Bonuses : " + bonus, ConsoleColor.Green);
            PrintStringOnPosition(20, 7, "Speed : " + speed, ConsoleColor.Green);

            Thread.Sleep((int)(600 - speed));
            
        }

    }
}
