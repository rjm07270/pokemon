using System;
using System.Collections.Generic;
using System.Text;


    abstract class Pokemon
    {
        /* Fields */

        public string Name { get; set; }
        public int level { get; set; }

        public Types type1 { get; set; }
        public Types type2 { get; set; }


        public int HPIV { get; set; }
        public int AttackIV { get; set; }
        public int DefenceIV { get; set; }
        public int SpAtkIV { get; set; }
        public int SpDefIV { get; set; }
        public int SpeedIV { get; set; }

        public int HPEV { get; set; }
        public int AttackEV { get; set; }
        public int DefenceEV { get; set; }
        public int SpAtkEV { get; set; }
        public int SpDefEV { get; set; }
        public int SpeedEV { get; set; }

        public int HP { get; set; }
        public int Attack { get; set; }

        public int Defence { get; set; }
        public int SpAtk { get; set; }
        public int SpDef { get; set; }
        public int Speed { get; set; }

    public int BattleAttack { get; set; }
    public int BattleDefence { get; set; }
    public int BattleSpAtk { get; set; }
    public int BattleSpDef { get; set; }
    public int BattleSpeed { get; set; }
    public int BattleAccuracy { get; set; }

    public int BattleEvasion { get; set; }


    public string Status { get; set; }

        public Moves[] BattleMoves { get; set; }


        public void MoveDump(Pokemon Pokemon)
    {
        for (int i = 0; i < Pokemon.BattleMoves.Length; i++)
        {
            Console.WriteLine((i+1) + ": " + Pokemon.BattleMoves[i].Name);
        }
    }





}





