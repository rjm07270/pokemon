﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    abstract class Moves
    {
        public Types type1 { get; set; }

        public string Kind { get; set; }
        public int Accuracy { get; set; }

        public int BaseDamage { get; set; }

        public int pp { get; set; }

        public double other { get; set; }
    }
}
