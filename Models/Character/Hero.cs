using System;
using WorldOfPain.Models.CharacterItems;

namespace WorldOfPain.Models.Character
{
    /// <summary>
    /// Represents a hero character in the game, derived from the <see cref="CharacterBase"/> class.
    /// </summary>
    public class Hero : CharacterBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hero"/> class with default parameters.
        /// </summary>
        public Hero()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hero"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the hero.</param>
        /// <param name="health">The health points of the hero.</param>
        /// <param name="attackDamage">The attack damage of the hero.</param>
        /// <param name="defense">The defense points of the hero.</param>
        /// <param name="x">The X-coordinate of the hero's position.</param>
        /// <param name="y">The Y-coordinate of the hero's position.</param>
        /// <param name="bag">The bag containing items carried by the hero.</param>
        public Hero(string name, int health, int attackDamage, int defense, int x, int y, Bag bag)
            : base(name, health, attackDamage, defense, x, y, bag)
        {
        }

        /// <summary>
        /// Moves the hero to the specified position.
        /// </summary>
        /// <param name="newX">The X-coordinate of the new position.</param>
        /// <param name="newY">The Y-coordinate of the new position.</param>
        public void Move(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        /// <summary>
        /// Attacks the specified enemy creature.
        /// </summary>
        /// <param name="enemy">The creature being attacked.</param>
        public void Attack(Creature enemy)
        {
            int damageDealt = Math.Max(AttackDamage - enemy.Defense, 0);
            enemy.Health -= damageDealt;
            Console.WriteLine($"{Name} attacks {enemy.Name} and deals {damageDealt} damage!");
        }
    }
}
