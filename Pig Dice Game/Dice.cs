using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pig_Dice_Game
{
    class Dice
    {
        int _Side;

        public void Roll()
        {
            int i = DateTime.Now.Millisecond % 6;
            i++;
            _Side = i;
            
        }

        public void AltRoll()
        {
            int i = DateTime.Now.Second % 6;
            i++;
            _Side = i;
        }

        public int Value
        {
            get { return this._Side; }
            set { this._Side = value; }
        }
    }
}
