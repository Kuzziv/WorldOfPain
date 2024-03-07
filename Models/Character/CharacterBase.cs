using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Models.Character
{
    public abstract class CharacterBase
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public int Defense { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public CharacterBase(string name, int health, int attackDamage, int defense, int x, int y)
        {
            Name = name;
            Health = health;
            AttackDamage = attackDamage;
            Defense = defense;
            X = x;
            Y = y;
        }

    }
}

