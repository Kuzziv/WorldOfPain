using System;
using WorldOfPain.Models.CharacterItems;

namespace WorldOfPain.Models.Character
{
    /// <summary>
    /// Represents a creature in the game, derived from the <see cref="CharacterBase"/> class.
    /// </summary>
    public class Creature : CharacterBase
    {
        private const int HuntingProximity = 3; // Define the proximity range for hunting
        private const int AttackRange = 1; // Define the attack range

        /// <summary>
        /// Initializes a new instance of the <see cref="Creature"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the creature.</param>
        /// <param name="health">The health points of the creature.</param>
        /// <param name="attackDamage">The attack damage of the creature.</param>
        /// <param name="defense">The defense points of the creature.</param>
        /// <param name="x">The X-coordinate of the creature's position.</param>
        /// <param name="y">The Y-coordinate of the creature's position.</param>
        /// <param name="bag">The bag containing items carried by the creature.</param>
        public Creature(string name, int health, int attackDamage, int defense, int x, int y, Bag bag)
            : base(name, health, attackDamage, defense, x, y, bag)
        {
        }


        /// <summary>
        /// Method to calculate distance between the creature and the player (hero).
        /// </summary>
        /// <param name="playerX">The X-coordinate of the player's position.</param>
        /// <param name="playerY">The Y-coordinate of the player's position.</param>
        /// <returns>The distance between the creature and the player.</returns>
        private double CalculateDistance(int playerX, int playerY)
        {
            return Math.Sqrt(Math.Pow(X - playerX, 2) + Math.Pow(Y - playerY, 2));
        }

        /// <summary>
        /// Method to check if the player is within the hunting proximity.
        /// </summary>
        /// <param name="playerX">The X-coordinate of the player's position.</param>
        /// <param name="playerY">The Y-coordinate of the player's position.</param>
        /// <returns>True if the player is within the hunting proximity, otherwise false.</returns>
        private bool IsPlayerWithinProximity(int playerX, int playerY)
        {
            double distance = CalculateDistance(playerX, playerY);
            return distance <= HuntingProximity;
        }

        /// <summary>
        /// Method to hunt down the player.
        /// </summary>
        /// <param name="playerX">The X-coordinate of the player's position.</param>
        /// <param name="playerY">The Y-coordinate of the player's position.</param>
        public void HuntPlayer(int playerX, int playerY)
        {
            if (IsPlayerWithinProximity(playerX, playerY))
            {
                // Calculate the direction towards the player
                int dx = Math.Sign(playerX - X); // 1 for right, -1 for left, 0 if on the same column
                int dy = Math.Sign(playerY - Y); // 1 for down, -1 for up, 0 if on the same row

                // Move towards the player's position along the X-axis or Y-axis, but not both
                if (dx != 0)
                {
                    X += dx;
                }
                else if (dy != 0)
                {
                    Y += dy;
                }

                // Additional hunting behavior can be added here
            }
        }

        /// <summary>
        /// Method for the creature to attack the player.
        /// </summary>
        /// <param name="player">The player (hero) being attacked.</param>
        public void AttackPlayer(Hero player)
        {
            double distance = CalculateDistance(player.X, player.Y);
            if (distance <= AttackRange)
            {
                int damageDealt = Math.Max(AttackDamage - player.Defense, 0);
                player.Health -= damageDealt;
                Console.WriteLine($"{Name} attacks {player.Name} and deals {damageDealt} damage!");
            }
        }
    }
}
