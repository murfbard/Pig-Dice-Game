using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pig_Dice_Game
{
    class Player
    {
        protected int Score = 0;
        String _Name = "";
        bool _ForcedLose = false;

        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }

        public bool ForcedLose
        {
            get { return this._ForcedLose; }
            set { this._ForcedLose = value; }
        }

        public bool TestEndTurn(int Die1, int Die2)
        {
            if (Die1 == 1 || Die2 == 1)
            {
                return true;
            }
            return false;
        }

        public bool TestLoseAllPoints(int Die1, int Die2)
        {
            if (Die1 == 1 && Die2 == 1)
            {
                return true;
            }
            return false;
        }

        public bool Roll()
        {
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
    }
}
