using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pokemon
{
    class Charizard : Pokemon
    {
        //IV and EV genorater
        private static Random RNG = new Random();
        public Charizard()

        {
            this.Name = "Charizard";

            this.type = "Fire,Flying";

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


        }

    }
}
