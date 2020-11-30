using System;
using System.Collections.Generic;
using System.Text;



    class DragonClaw : Moves
    {

        public DragonClaw()
        {
            this.Name = "DragonClaw";
            this.type1 = Types.Dragon;
            this.Kind = "Physical";
            this.Accuracy = 100;
            this.BaseDamage = 80;
            this.pp = 15;
            this.other = 1;
            //burn=10;
        }

public override void status(Pokemon atk, Pokemon def, int damage)
    {
        
    }
}

