﻿using System;
using System.Collections.Generic;
using System.Text;



    class WingedAttack : Moves
    {

        public WingedAttack()
        {
            this.Name = "Winged Attack";
            this.type1 = Types.Flying;
            this.Kind = "Physical";
            this.Accuracy = 100;
            this.BaseDamage = 60;
            this.pp = 35;
            this.other = 1;
            //burn=10;
        }

public override void status(Pokemon atk, Pokemon def, int damage)
    {
        
    }
}

