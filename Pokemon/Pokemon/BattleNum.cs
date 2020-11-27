using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{//fdsaljkdf;sal;ksdaf;jl
    class BattleNum
    {
        private static Random RNG = new Random();
        public int BattleDamage(Pokemon atk, Pokemon def, Moves move)
        {
            int damage=0;
            int Accuracy = RNG.Next(0,100);
            double modifier = 1.0;


            
            if (move.Accuracy >= Accuracy)
            {
                if(move.Kind == "Special")
                {
                    damage = Convert.ToInt32((((2 * atk.level / 5) + 2)*move.BaseDamage*atk.SpAtk/def.SpDef/50 +2)* modifier);
                }
                else
                {
                    damage = Convert.ToInt32((((2 * atk.level / 5) + 2) * move.BaseDamage * atk.Attack / def.Defence / 50 + 2) * modifier);
                }
            }
            else
            {
                Console.WriteLine(atk.Name + "Missed");
            }

            return damage;

            
        }
        public int Effective(Pokemon atk, Pokemon def)
        {
            int timesEfect = 1;


            int[,] effect = new int[19, 19]
            {
                // None  Normal   Fire   Water  Grass  Flying  Fighting  Poison  Electric  Ground  Rock  Psychic  Ice  Bug  Ghost  Steel  Dragon  Dark  Fairy
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  //None
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Normal
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Fire
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Water
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Grass
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Flying
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Fighting
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Poison
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Electric
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Ground
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Psychic
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Ice
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // Bug
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  //
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  //
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // 
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  // 
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  //
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  //
            };


            return timesEfect;


        }
    }
}
