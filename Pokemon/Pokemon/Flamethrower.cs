using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{

    class Flamethrower : Moves
    {



        public Flamethrower()
        {
            this.Name = "Flamethrower";
            this.type1 = Types.Fire;
            this.Kind = "Special";
            this.Accuracy = 100;
            this.BaseDamage = 90;
            this.pp = 15;
            this.other = 1;
            //burn=10;
        }
    }
}
