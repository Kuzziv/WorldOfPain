using System;
using WorldOfPain.Models.CharacterItems;

namespace WorldOfPain.Models.Character
{
    public class Hero : CharacterBase
    {
        public Hero()
        {
        }

        public Hero(string name, int health, int attackDamage, int defense, int x, int y, Bag bag)
            : base(name, health, attackDamage, defense, x, y, bag)
        {
        }

        public void Move(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        public void Attack(Creature enemy)
        {
            int damageDealt = Math.Max(AttackDamage - enemy.Defense, 0);
            enemy.Health -= damageDealt;
            Console.WriteLine($"{Name} attacks {enemy.Name} and deals {damageDealt} damage!");
        }
    }
}
