using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{

    class Flamethrower : Moves
    {

        
        
        public Flamethrower()
        {
            this.Type = "Fire";
            this.Kind = "Special";
            this.Accuracy = 100;
            this.BaseDamage = 90;
            this.pp = 15;
            //burn=10;
        }
    }
}
