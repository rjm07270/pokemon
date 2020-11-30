using System;
using System.Collections.Generic;
using System.Text;



    class FlareBlitz : Moves
    {

        public FlareBlitz()
        {
            this.Name = "Flare Blitz";
            this.type1 = Types.Fire;
            this.Kind = "Physical";
            this.Accuracy = 100;
            this.BaseDamage = 120;
            this.pp = 15;
            this.other = 1;
            //burn=10;
        }

public override void status(Pokemon atk, Pokemon def, int damage)
    {
       
    }
}

