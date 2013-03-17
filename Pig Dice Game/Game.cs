using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pig_Dice_Game
{
    class Game
    {
        bool continueGame = true;
        bool IsPlayerTurn = false;
        int ScoreToWin = 70;

        CPU cpuPlayer = new CPU();
        Human humanPlayer = new Human();


        public void NewGame()
        {

            GameMesssages.BeginGame(ScoreToWin);

            do
            {
                if (IsPlayerTurn)
                {
                    GameMesssages.TurnBegins(humanPlayer, cpuPlayer);

                    humanPlayer.BeginTurn(humanPlayer, cpuPlayer, ScoreToWin);

                    IsPlayerTurn = false;
                }
                else
                {
                    GameMesssages.TurnBegins(cpuPlayer, humanPlayer);

                    cpuPlayer.CPUTurn(humanPlayer, cpuPlayer, ScoreToWin);

                    IsPlayerTurn = true;
                }

                if (cpuPlayer.Score >= ScoreToWin
                    || humanPlayer.Score >= ScoreToWin 
                    || cpuPlayer.ForcedLose
                    || humanPlayer.ForcedLose)
                {
                    continueGame = false;
                }
            } while (continueGame);

            GameMesssages.EndGame(humanPlayer, cpuPlayer, ScoreToWin);

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

        }






    }
}
