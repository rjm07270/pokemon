using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather outside = Weather.Noraml;

            Charizard Charizard = new Charizard();
            Blastoise Blastoise = new Blastoise();
            Flamethrower x = new Flamethrower();
            HydroPump HydroPump = new HydroPump();

            int Damage;

            //Console.WriteLine(Charizard.BattleMoves[0].Name);

            Console.WriteLine(Blastoise.HP);
            Console.WriteLine(Charizard.HP);

            //Console.WriteLine(Charizard.MoveDump(Charizard.BattleMoves[0])) ;
            Damage = BattleDamage(Charizard, Blastoise, Charizard.BattleMoves[0], outside);
            Blastoise.HP -= Damage;
            Console.WriteLine(Damage);
            Console.WriteLine(Blastoise.HP);




        }
        public static int BattleDamage(Pokemon atk, Pokemon def, Moves move, Weather outside)
        {

            int damage = 0;
            if (move.pp > 0)
            {

                Random RNG = new Random();
                
                double random = (RNG.Next(85, 100) / 100);
                int Accuracy = RNG.Next(0, 100);
                double modifier;
                double forcast = Forcast(outside, move);
                double critical = Critical();
                double sTAB = STAB(atk, move);
                double typeEffect = TypeEffect(def, move);
                double burned = Burned(atk, move);
                double Other = move.other;


                modifier = forcast * critical * sTAB * typeEffect * burned * Other;


                // modifier = Forcast(outside, move) * Critical() * random * STAB(atk, move) * TypeEffect(atk, def, move) * Burned(atk, move) * Other;
                /*Console.WriteLine("forcast=" + forcast);
                Console.WriteLine("critical=" + critical);
                Console.WriteLine("sTAB=" + sTAB);
                Console.WriteLine("typeEffect=" + typeEffect);
                Console.WriteLine("burned=" + burned);
                Console.WriteLine("Other=" + Other);
                Console.WriteLine("modifier=" + modifier);*/

                if (move.Accuracy >= Accuracy)
                {
                    if (move.Kind == "Special")
                    {
                        damage = Convert.ToInt32((((2 * atk.level / 5) + 2) * move.BaseDamage * atk.SpAtk / def.SpDef / 50 + 2) * modifier);
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

                move.pp -= 1;

                return damage;

            }
            else
            {
                Console.WriteLine("Out of PP for " + move.Name);
                return 0;
                
            }
        }

        public static double Forcast(Weather outside, Moves move)
        {

            if (outside == Weather.sunlight && move.type1 == Types.Fire)
            {
                return 1.5;

            }
            else if (outside == Weather.sunlight && move.type1 == Types.Water)
            {
                return 0.5;

            }
            else if (outside == Weather.rain && move.type1 == Types.Water)
            {
                return 1.5;

            }
            else if (outside == Weather.rain && move.type1 == Types.Fire)
            {
                return 0.5;

            }
            else
            {
                return 1.0;
            }
        }
        public static double TypeEffect(Pokemon def, Moves move)
        {
            double timesEffect;

            double[,] effect = new double[19, 19]
             {
                // None  Normal   Fire   Water  Grass  Flying  Fighting  Poison  Electric  Ground  Rock  Psychic  Ice  Bug  Ghost  Steel  Dragon  Dark  Fairy
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,     1,     1,     1,    1},  //None
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,    .5,     1,      1,   1,    0,    .5,     1,     1,    1},  // Normal
                {    1,     1,     .5,     .5,    2,      1,        1,      1,       1,       1,    .5,     1,      2,   2,    1,     2,    .5,     1,    1},  // Fire
                {    1,     1,      2,     .5,   .5,      1,        1,      1,       1,       2,     2,     1,      1,   1,    1,     1,    .5,     1,    1},  // Water
                {    1,     1,     .5,      2,   .5,     .5,        1,     .5,       1,       1,     1,     1,      1,  .5,    1,    .5,    .5,     1,    1},  // Grass
                {    1,     1,      1,      1,    2,      1,        2,      1,      .5,       1,    .5,     1,      1,   2,    1,    .5,     1,     1,    1},  // Flying
                {    1,     2,      1,      1,    1,     .5,        1,     .5,       1,       1,     2,    .5,      2,  .5,    0,     2,     1,     2,   .5},  // Fighting
                {    1,     1,      1,      1,    2,      1,        1,     .5,       1,      .5,    .5,     1,      1,   1,   .5,     0,     1,     1,    2},  // Poison
                {    1,     1,      1,      2,   .5,      2,        1,      1,      .5,       0,     1,     1,      1,   1,    1,     1,    .5,     1,    1},  // Electric
                {    1,     1,      2,      1,   .5,      1,        0,      2,       2,       1,     2,     1,      1,  .5,    1,     2,     1,     1,    1},  // Ground
                {    1,     1,      2,      1,    1,      2,       .5,      1,       1,      .5,     2,     1,      2,   1,    1,    .5,     1,     1,    1},  // Rock
                {    1,     1,      1,      1,    1,      1,        2,      2,       1,       1,     1,    .5,      1,   1,    1,     1,     1,     0,    1},  // Psychic
                {    1,     1,     .5,     .5,    2,      2,        1,      1,       1,       2,     1,     1,     .5,   1,    1,    .5,     2,     1,    1},  // Ice
                {    1,     1,     .5,      1,    2,     .5,       .5,     .5,       1,       1,     1,     2,      1,   1,   .5,     1,     1,     2,    1},  // Bug
                {    1,     0,      1,      1,    1,      1,        1,      1,       1,       1,     1,     2,      1,   1,    1,     1,     1,    .5,    1},  // Ghost
                {    1,     1,     .5,     .5,    1,      1,        1,      1,      .5,       1,     2,     1,      2,   1,    1,    .5,     1,     1,    2},  // Steel
                {    1,     1,      1,      1,    1,      1,        1,      1,       1,       1,     1,     1,      1,   1,    1,    .5,     2,     1,    0},  // Dragon
                {    1,     1,      1,      1,    1,      1,       .5,      1,       1,       1,     1,     2,      1,   1,    2,     1,     1,    .5,   .5},  // Dark
                {    1,     1,     .5,      1,    1,      1,        2,     .5,       1,       1,     1,     1,      1,   1,    1,     1,     2,     2,    1},  // Fairy
             };


            double timesEffect1 = effect[Convert.ToInt32(move.type1), Convert.ToInt32(def.type1)];
            double timesEffect2 = effect[Convert.ToInt32(move.type1), Convert.ToInt32(def.type2)];

            if (timesEffect1 == 0 || timesEffect2 == 0)
            {
                timesEffect = 0;

            }
            else if (Convert.ToInt32(def.type1) == 0)
            {
                timesEffect = timesEffect2;

            }
            else if (Convert.ToInt32(def.type2) == 0)
            {
                timesEffect = timesEffect1;
            }
            else if (timesEffect1 == .5 && timesEffect2 == 1)
            {
                timesEffect = 1;

            }
            else if (timesEffect2 == .5 && timesEffect1 == 1)
            {
                timesEffect = 1;
            }

            else
            {
                timesEffect = timesEffect1 * timesEffect2;
            }

            return timesEffect;


        }
        public static double STAB(Pokemon atk, Moves move)
        {
            if (move.type1 == atk.type1 || move.type1 == atk.type2)
            {
                return 1.5;
            }
            else
                return 1.0;
        }
        public static double Critical()
        {
            Random RNG = new Random();
            double Crit = (RNG.Next(0, 100));



            if (Crit / 100.0 <= 6.25)
            {
                return 1.0;
            }
            else
            {
                return 1.0;
            }
        }
        public static double Burned(Pokemon atk, Moves move)
        {

            if (atk.Status == "Burned" && move.Kind == "physical")
            {
                return 0.5;
            }
            else
            {
                return 1.0;
            }

        }

    }

}



