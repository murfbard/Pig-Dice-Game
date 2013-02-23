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
        public void PlayerTurn()
        {
            bool TurnContinues = true;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Player Turn -- Your score is " + Score);
                Console.WriteLine("Do you want to roll? (y/n)");
                System.ConsoleKeyInfo key = Console.ReadKey();

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

            }
            while (TurnContinues);

            Console.WriteLine("");
            Console.WriteLine("Player Turn is over, CPU turn begins.");
            Console.WriteLine("Hit any key to begin CPU turn.");
            Console.ReadKey();

        }


    }
}
