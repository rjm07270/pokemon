using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;



class Blastoise : Pokemon
{
    //IV and EV genorater
    private static Random RNG = new Random();
    public Blastoise()

    {
        this.Name = "Blastoise";

        this.type1 = Types.Water;
        this.type2 = Types.None;


        this.HPIV = RNG.Next(32);
        this.AttackIV = RNG.Next(32);
        this.DefenceIV = RNG.Next(32);
        this.SpAtkIV = RNG.Next(32);
        this.SpDefIV = RNG.Next(32);
        this.SpeedIV = RNG.Next(32);


        this.HPEV = 0;
        this.AttackEV = 0;
        this.DefenceEV = 0;
        this.SpAtkEV = 0;
        this.SpDefEV = 0;
        this.SpeedEV = 0;


        this.HP = 79;
        this.Attack = 83;
        this.Defence = 100;
        this.SpAtk = 85;
        this.SpDef = 105;
        this.Speed = 78;

        this.level = 50;

        this.BattleAttack = 0;
        this.BattleDefence = 0;
        this.BattleSpAtk = 0;
        this.BattleSpDef = 0;
        this.BattleSpeed = 0;
        this.BattleAccuracy = 0;
        this.BattleEvasion = 0;
        this.Status = "";


        this.BattleMoves = new Moves[4];

        this.BattleMoves[0] = new HydroPump();
        this.BattleMoves[1] = new IceBeam();
        this.BattleMoves[2] = new TakeDown();
        this.BattleMoves[3] = new HydroPump();

    }
}

       

