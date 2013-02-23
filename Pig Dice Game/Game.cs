using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pig_Dice_Game
{
    class Game
    {
        int CPUScore = 0;
        int PlayerScore = 0;
        bool continueGame = true;
        bool IsPlayerTurn = false;
        int ScoreToWin = 100;

        CPU cpuPlayer = new CPU();
        Human humanPlayer = new Human();


        public void NewGame()
        {
            Console.WriteLine("Pig, Keith's edition!");
            Console.WriteLine("");
            Console.WriteLine("Each turn you roll 2 dice.");
            Console.WriteLine("If you get double 1s, you automatically LOSE.");
            Console.WriteLine("If you get a single 1, you don't add the points and your turn is over.");
            Console.WriteLine("If you do not get a 1, you add your points and you can go again IF you choose!");
            Console.WriteLine("");
            Console.WriteLine("First to 100 wins! (if your opponent is eliminated you win)");

            do
            {


                if (IsPlayerTurn)
                {
                    
                    humanPlayer.PlayerTurn();

                    IsPlayerTurn = false;
                }
                else
                {
                    cpuPlayer.CPUTurn();

                    IsPlayerTurn = true;
                }

                if (CPUScore > ScoreToWin 
                    || PlayerScore > ScoreToWin 
                    || cpuPlayer.ForcedLose
                    || humanPlayer.ForcedLose)
                {
                    continueGame = false;
                }
            } while (continueGame);

            if(CPUScore > ScoreToWin || humanPlayer.ForcedLose)
            {
                Console.WriteLine("");
                Console.WriteLine("The computer beat you!");
            }
            else if(PlayerScore > ScoreToWin || cpuPlayer.ForcedLose)
            {
                Console.WriteLine("");
                Console.WriteLine("You beat the computer!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("I don't know what happened!");
            }
            Console.WriteLine("");
            Console.WriteLine("Hit any key to end the game.");
            Console.ReadKey();
            
        }



        public void PlayerTurn()
        {
            Console.WriteLine("Playerturn!");
            Console.ReadKey();
        }

        

        
    }
}
