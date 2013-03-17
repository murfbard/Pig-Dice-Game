using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pig_Dice_Game
{
    class Human : Player
    {
        public Human()
        {
            Name = "Player";
        }

        public void BeginTurn(Player human, Player cpu, int ScoreToWin)
        {
            bool TurnContinues = true;

            do
            {
                GameMesssages.GetScore(human, cpu);
                Console.WriteLine("Do you want to roll? (y/n)");
                System.ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine("");

                if (key.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Player Ended his turn!");
                    TurnContinues = false;
                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("Player has decided to roll!");
                    TurnContinues = Roll();
                }
                else
                {
                    Console.WriteLine("You can only type y or n here.");
                }

                if (TurnContinues)
                {
                    TurnContinues = !DidIWin(ScoreToWin);
                }

            }
            while (TurnContinues);

            Console.WriteLine("");
            Console.WriteLine("Player Turn is over.");
            Console.WriteLine("Hit any key to continue.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
