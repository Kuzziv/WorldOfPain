﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Config.ModelsSettings
{
    public class PlayerSettings
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public int Defense { get; set; }
        public int StartingX { get; set; }
        public int StartingY { get; set; }
        public int MaxBagSlots { get; set; }
    }
}
