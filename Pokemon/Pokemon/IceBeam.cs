using System;
using System.Collections.Generic;
using System.Text;


    class IceBeam : Moves
{

    public IceBeam()
        {
            this.Name = "IceBeam";
            this.type1 = Types.Ice;
            this.Kind = "Special";
            this.Accuracy = 100;
            this.BaseDamage = 90;
            this.pp = 10;
            this.other = 1;
            
        }

public override void status(Pokemon atk, Pokemon def, int damage)
    {
        Random RNG = new Random();
        int BurnChance = RNG.Next(0, 9);

        if (BurnChance == 0)
        {
            def.Status = "Forzen";
        }
        
    }

    }

