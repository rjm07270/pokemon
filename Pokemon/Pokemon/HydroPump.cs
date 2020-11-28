using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{

    class HydroPump : Moves
    {



        public HydroPump()
        {
            this.type1 = Types.Water;
            this.Kind = "Special";
            this.Accuracy = 80;
            this.BaseDamage = 110;
            this.pp = 5;
            this.other = 1;
            //burn=10;
        }
    }
}
