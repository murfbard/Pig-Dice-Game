using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pig_Dice_Game
{
    abstract class Player
    {
        // The player class is used as the base class for Human, CPU, and all 
        // objects that play the game.
        // -- Keith Murphy 2/28/2013 aka KM1

        #region Class Variables
        protected int _Score = 0;
        String _Name = "";
        bool _ForcedLose = false;
        #endregion

        #region Properties

        public string Name
        {
            // I created this so the game could retrieve the name of the class. (KM1)
            get { return this._Name; }
            set { this._Name = value; }
        }

        public bool ForcedLose
        {
            // This is made true when the player does something that causes an instant-lose condition. (KM1)
            get { return this._ForcedLose; }
            set { this._ForcedLose = value; }
        }

        public int Score
        {
            // By keeping the score on the player, the game does not need to track it.  Also this allows the game
            // to be expanded to more players much easier. (KM1)
            get { return this._Score; }
            set { this._Score = value; }
        }

        #endregion

        #region Functions

        public bool TestEndTurn(int Die1, int Die2)
        {
            // In Pig, if anyone roles a 1, their turn is over. (KM1)

            if (Die1 == 1 || Die2 == 1)
            {
                return true;
            }
            return false;
        }

        public bool TestLoseAllPoints(int Die1, int Die2)
        {
            // In Pig, if anyone roles two 1s, they immediately lose. (KM1)

            if (Die1 == 1 && Die2 == 1)
            {
                return true;
            }
            return false;
        }

        public bool DidIWin(int ScoreToWin)
        {
            if (ScoreToWin <= this.Score)
            {
                return true;
            }
            return false;
        }

        public bool Roll()
        {
            //
            bool TurnContinues = true;

            Dice d1 = new Dice();
            Dice d2 = new Dice();

            d1.Roll();
            d2.AltRoll();

            Console.WriteLine(Name + " rolled a " + d1.Value.ToString() + ", and a " + d2.Value.ToString() + "!");

            if (TestEndTurn(d1.Value, d2.Value))
            {
                TurnContinues = false;
                Console.WriteLine("Turn ends, " + Name + " rolled a 1!");

                if (TestLoseAllPoints(d1.Value, d2.Value))
                {
                    ForcedLose = true;
                    Console.WriteLine(Name + " loses because they rolled double 1s!");
                }
            }
            else
            {
                Console.WriteLine(Name + " adds " + d1.Value.ToString() + " and " + d2.Value.ToString() + " to his score!");
                Score = Score + d1.Value + d2.Value;
            }

            return TurnContinues;
        }
        #endregion
    }
}
