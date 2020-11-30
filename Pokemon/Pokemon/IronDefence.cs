using System;
using System.Collections.Generic;
using System.Text;


    class IronDefence : Moves
    {
    public IronDefence()
    {
        this.Name = "IronDefence";
        this.type1 = Types.Steel;
        this.Kind = "Status";
        this.Accuracy = 10000000;
        this.BaseDamage = 0;
        this.pp = 15;
        this.other = 1;
    }

    public override void status(Pokemon atk, Pokemon def, int damage)
    {

        atk.BattleDefence += 2;


    }

}

