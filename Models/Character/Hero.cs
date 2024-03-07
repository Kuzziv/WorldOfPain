using System;

namespace WorldOfPain.Models.Character
{
    public class Hero : CharacterBase
    {
        public Hero(string name, int health, int attackDamage, int defense, int x, int y)
            : base(name, health, attackDamage, defense, x, y)
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
