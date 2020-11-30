using System;
using System.Collections.Generic;
using System.Text;


    class TakeDown : Moves
    {
    public TakeDown()
    {
        this.Name = "Take Down";
        this.type1 = Types.Normal;
        this.Kind = "Physical";
        this.Accuracy = 85;
        this.BaseDamage = 90;
        this.pp = 20;
        this.other = 1;

    }

    public override void status(Pokemon atk, Pokemon def, int damage)
    {
        atk.HP -= damage / 4;

    }
}

