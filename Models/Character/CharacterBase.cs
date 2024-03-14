using System;
using WorldOfPain.Models.CharacterItems;

namespace WorldOfPain.Models.Character
{
    /// <summary>
    /// Represents a base class for characters in the game.
    /// </summary>
    public abstract class CharacterBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterBase"/> class.
        /// </summary>
        protected CharacterBase()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterBase"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="health">The health points of the character.</param>
        /// <param name="attackDamage">The attack damage of the character.</param>
        /// <param name="defense">The defense points of the character.</param>
        /// <param name="x">The X-coordinate of the character's position.</param>
        /// <param name="y">The Y-coordinate of the character's position.</param>
        /// <param name="bag">The bag containing items carried by the character.</param>
        public CharacterBase(string name, int health, int attackDamage, int defense, int x, int y, Bag bag)
        {
            Name = name;
            Health = health;
            AttackDamage = attackDamage;
            Defense = defense;
            X = x;
            Y = y;
            Bag = bag;
        }

        /// <summary>
        /// Gets or sets the name of the character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the health points of the character.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Gets or sets the attack damage of the character.
        /// </summary>
        public int AttackDamage { get; set; }

        /// <summary>
        /// Gets or sets the defense points of the character.
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// Gets or sets the X-coordinate of the character's position.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate of the character's position.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the bag containing items carried by the character.
        /// </summary>
        public Bag Bag { get; set; }
    }
}
