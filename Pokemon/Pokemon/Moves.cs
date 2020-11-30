using System;
using System.Collections.Generic;
using System.Text;



abstract class Moves
{

    public string Name { get; set; }
    public Types type1 { get; set; }
    public string Kind { get; set; }
    public int Accuracy { get; set; }

    public int BaseDamage { get; set; }

    public int pp { get; set; }

    public double other { get; set; }

    public Moves[] BattleMoves { get; set; }

    public abstract void status(Pokemon atk, Pokemon def, int damage);
}
