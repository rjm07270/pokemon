using System;


    class Program
    {
    static void Main(string[] args)
        {
        Weather outside = Weather.Noraml;

        Charizard Charizard = new Charizard();
        Blastoise Blastoise = new Blastoise();
          

            int Damage;


        while (Charizard.HP > 0 && Blastoise.HP > 0)
        {
            Damage=0;
            Console.WriteLine(Blastoise.Name + " HP= " + Blastoise.HP);
            Console.WriteLine(Charizard.Name + " HP= " + Charizard.HP);
            if ((Charizard.Speed + Charizard.BattleSpeed > Blastoise.Speed + Blastoise.BattleSpeed))
            {
                Damage = BattleDamage(Charizard, Blastoise, Charizard.BattleMoves[BattleSelect(Charizard)], outside);
                Console.WriteLine("Damgae= " + Damage);
                Blastoise.HP -= Damage;
                if (Blastoise.HP < 0)
                {
                    Console.WriteLine(Blastoise.Name + " HP= " + Blastoise.HP);
                    Console.WriteLine(Blastoise.Name + " Fainted");
                    break;
                }
                Damage = BattleDamage(Blastoise, Charizard, Blastoise.BattleMoves[BattleRandom(Blastoise)], outside);
                Console.WriteLine("Damgae= " + Damage);
                Charizard.HP -= Damage;
            }
            else
            {
                Damage = BattleDamage(Blastoise, Charizard, Blastoise.BattleMoves[BattleRandom(Blastoise)], outside);
                Console.WriteLine("Damgae= " + Damage);
                Charizard.HP -= Damage;
                if (Charizard.HP < 0)
                {
                    Console.WriteLine(Charizard.Name + " HP= " + Charizard.HP);
                    Console.WriteLine(Charizard.Name + " Fainted") ;
                    break;
                }
                Damage = BattleDamage(Charizard, Blastoise, Charizard.BattleMoves[BattleSelect(Charizard)], outside);
                Console.WriteLine("Damgae= "+Damage);
                Blastoise.HP -= Damage;
            }
            
            Console.WriteLine(Blastoise.Name + " HP= " + Blastoise.HP);
            Console.WriteLine(Charizard.Name + " HP= " + Charizard.HP);
            if (Charizard.HP < 0)
            {
                Console.WriteLine(Charizard.Name + " Fainted");
            }
            if (Blastoise.HP < 0)
            {
                Console.WriteLine(Blastoise.Name + " Fainted");
            }
        }
       

        }


    public static int BattleSelect(Pokemon atk)
        {
           
            Console.WriteLine("Select attack");
            atk.MoveDump(atk);
            int input = Convert.ToInt32(Console.ReadLine());
            while(input<1 || input > 4)
            {
                Console.WriteLine("Must enter a Value of 1 - 4");
                Console.WriteLine("Select attack");
                atk.MoveDump(atk);
                input = Convert.ToInt32(Console.ReadLine());
            }
            while (atk.BattleMoves[input-1].pp < 0)
            {
                Console.WriteLine(atk.Name + " is out of pp For " + atk.BattleMoves[input-1].Name);
                Console.WriteLine("Select attack");
                atk.MoveDump(atk);
                input = Convert.ToInt32(Console.ReadLine());
            }
        Console.WriteLine(atk.Name + " Used " + atk.BattleMoves[input - 1].Name);
        return input-1;

        }
    public static int BattleRandom(Pokemon atk)
    {
        Random RNG = new Random();

        int Random = RNG.Next(0, 3);
        
        while (atk.BattleMoves[Random].pp < 0)
        {
            Random = RNG.Next(0, 3);
        }
        Console.WriteLine(atk.Name + " Used " + atk.BattleMoves[Random].Name);
        
        return Random;

    }
    public static int BattleDamage(Pokemon atk, Pokemon def, Moves move, Weather outside)
        {

            int damage = 0;
           

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



                if (move.Accuracy+atk.BattleAccuracy >= Accuracy)
                {

           
            if (atk.Status == "Asleep")
            {
                int sleeptest = RNG.Next(0, 1);
                if (sleeptest == 1)
                {

                    Console.WriteLine(atk.Name + " Is asleep");
                    return  0;
                }
                else
                {
                    atk.Status = "";
                    Console.WriteLine(atk.Name + " Woke up");
                    BattleDamage(atk, def, move, outside);
                }
            }
            if (atk.Status == "Confused")
            {
                Console.WriteLine(atk.Name + " Is Confused");
                int hitself = RNG.Next(0, 2);
                if (hitself == 0)
                {
                    atk.HP -= atk.HP / 16;
                    Console.WriteLine(atk.Name + " Hurt itself in its Confusion");
                    return 0;
                    
                }
            }
            if (atk.Status == "Paralysis ")
            {
                int Stopped = RNG.Next(0, 3);
                atk.BattleSpeed = atk.Speed / 2;
                if(Stopped == 0)
                {
                Console.WriteLine(atk.Name + " is paralyzed and unable to move");
                    return 0;
                }
                if (atk.Status == "Frozen ")
                {
                    int Freeze = RNG.Next(0, 4);
                    if (Freeze == 0)
                    {
                        atk.Status = "";
                    }
                    Console.WriteLine(atk.Name + " is Frozen solid");
                }
            }

                if (move.Kind == "Special")
                    {
                         move.status(atk, def, damage);
                         damage = Convert.ToInt32((((2 * atk.level / 5) + 2) * move.BaseDamage * (atk.SpAtk + atk.BattleSpAtk) / (def.SpDef + def.BattleSpDef) / 50 + 2) * modifier);
                    }
                    else if (move.Kind == "Physical")
                    {
                        move.status(atk, def, damage);
                        damage = Convert.ToInt32((((2 * atk.level / 5) + 2) * move.BaseDamage * (atk.Attack + atk.BattleAttack) / (def.Defence + def.BattleDefence) / 50 + 2)* modifier);
                    }
                    else
                    {
                        move.status(atk, def, damage);   
                        
                    }
                //Console.WriteLine(atk.Name + " Used " + move.Name);


                }
                else
                {
                    Console.WriteLine(atk.Name + "Missed");
                }

        if (atk.Status == "Burned")
        {

            Console.WriteLine(atk.Name + " was hurt by the burn");
            atk.HP -= atk.HP / 16;


        }
        if (atk.Status == "Poisoned")
        {

            Console.WriteLine(atk.Name + " was hurt by the poison");
            atk.HP -= atk.HP / 16;


        }

        move.pp -= 1;

        if (critical > 1)
        {
            Console.WriteLine("A Critical hit");
        }
        if (typeEffect > 1)
        {
            Console.WriteLine("Its Super Effective");
        }
        if (typeEffect < 1)
        {
            Console.WriteLine("Its not very Effective");
        }

                return damage;

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




