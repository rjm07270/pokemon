using System;
using System.Collections.Generic;
using System.Text;


class Hitself : Moves
{

    public Hitself()
    {
        this.Name = "Hurt is self in its confusion";
        this.type1 = Types.None;
        this.Kind = "Physical";
        this.Accuracy = 1000000;
        this.BaseDamage = 40;
        this.pp = 1;
        this.other = 1;
    }


    public override void status(Pokemon atk, Pokemon def, int damage)
    {
        
    }
}

