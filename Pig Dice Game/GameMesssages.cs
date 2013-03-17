using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pig_Dice_Game
{
    static class GameMesssages
    {
        static public void TurnBegins(Player activeplayer, Player opponent)
        {
            Console.WriteLine("");
            Console.WriteLine("Begin " + activeplayer.Name + " Turn");
        }

        static public void BeginGame(int ScoreToWin)
        {
            Console.WriteLine("Pig, Keith's edition!");
            Console.WriteLine("");
            Console.WriteLine("Each turn you roll 2 dice.");
            Console.WriteLine("If you get double 1s, you automatically LOSE.");
            Console.WriteLine("If you get a single 1, you don't add the points and your turn is over.");
            Console.WriteLine("If you do not get a 1, you add your points and you can go again IF you choose!");
            Console.WriteLine("");
            Console.WriteLine("First to " + ScoreToWin + " wins! (if your opponent is eliminated you win)");
        }

        static public void EndGame(Player humanPlayer, Player cpuPlayer, int ScoreToWin)
        {
            Console.WriteLine("");
            GetScore(humanPlayer, cpuPlayer);

            if (cpuPlayer.Score > ScoreToWin || humanPlayer.ForcedLose)
            {
                Console.WriteLine("The computer beat you!");
            }
            else if (humanPlayer.Score > ScoreToWin || cpuPlayer.ForcedLose)
            {
                Console.WriteLine("You beat the computer!");
            }
            else
            {
                Console.WriteLine("I don't know what happened!");
            }

            Console.WriteLine("");
            Console.WriteLine("Hit any key to end the game.");
        }

        static public void GetScore(Player activeplayer, Player opponent)
        {
            Console.WriteLine("Score is currently -- " + activeplayer.Name + ":" + activeplayer.Score + " to " + opponent.Name + ":" + opponent.Score); 
        }
    }
}
