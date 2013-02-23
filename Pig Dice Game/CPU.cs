using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pig_Dice_Game
{
    class CPU : Player
    {
        public CPU()
        {
            this.Name = "CPU";
        }

        public void CPUTurn()
        {
            bool TurnContinues = true;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Begin CPU Turn -- CPU Score is currently " + Score);

                if (AITestForReroll(Score))
                {
                    TurnContinues = Roll();
                }
                else
                {
                    TurnContinues = false;
                }
                Console.WriteLine("");
                Console.WriteLine("Hit any key to continue.");
                Console.ReadKey();
            }
            while (TurnContinues);

            Console.WriteLine("");
            Console.WriteLine("CPU Turn is over, Player turn begins.");
            Console.WriteLine("Hit any key to begin Player turn.");
            Console.ReadKey();

        }

        public bool AITestForReroll(int Score)
        {
            if (Score < 60)
            {
                return true;
            }
            return false;
        }

        
    }
}
