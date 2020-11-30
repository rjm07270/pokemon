using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;



    class Charizard : Pokemon
    {
        //IV and EV genorater
        private static Random RNG = new Random();
        public Charizard()

        {
            this.Name = "Charizard";

            this.type1 = Types.Fire;
            this.type2 = Types.Flying;


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


            this.HP = 78;
            this.Attack = 84;
            this.Defence = 78;
            this.SpAtk = 109;
            this.SpDef = 85;
            this.Speed = 100;

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

            this.BattleMoves[0]= new Flamethrower();
            this.BattleMoves[1] = new DragonClaw();
            this.BattleMoves[2] = new WingedAttack();
            this.BattleMoves[3] = new FlareBlitz();


            


        }

        

    }
