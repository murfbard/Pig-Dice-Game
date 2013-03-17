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

        public void CPUTurn(Player human, Player cpu, int ScoreToWin)
        {
            bool TurnContinues = true;

            do
            {
                if (AITestForReroll(cpu.Score, human.Score))
                {
                    TurnContinues = Roll();
                }
                else
                {
                    Console.Write("The CPU has decided to end his turn.");
                    TurnContinues = false;
                }

                if (TurnContinues)
                {
                    TurnContinues = !DidIWin(ScoreToWin);
                }

                if (TurnContinues)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Hit any key to continue the CPU's turn.");
                    Console.ReadKey();
                    Console.WriteLine("");
                }

            }
            while (TurnContinues);

            Console.WriteLine("");
            Console.WriteLine("CPU Turn is over.");
            Console.WriteLine("Hit any key to continue.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

        }

        public bool AITestForReroll(int Score, int OpponentScore)
        {
            if (Score < OpponentScore + 20)
            {
                return true;
            }
            return false;
        }

        
    }
}
