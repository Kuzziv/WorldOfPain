using System;

namespace WorldOfPain.Models.Character
{
    public class Creature : CharacterBase
    {
        private const int HuntingProximity = 3; // Define the proximity range for hunting
        private const int AttackRange = 1; // Define the attack range

        public Creature(string name, int health, int attackDamage, int defense, int x, int y)
            : base(name, health, attackDamage, defense, x, y)
        {
        }
    

        // Method to calculate distance between the creature and the player (hero)
        private double CalculateDistance(int playerX, int playerY)
        {
            return Math.Sqrt(Math.Pow(X - playerX, 2) + Math.Pow(Y - playerY, 2));
        }

        // Method to check if the player is within the hunting proximity
        private bool IsPlayerWithinProximity(int playerX, int playerY)
        {
            double distance = CalculateDistance(playerX, playerY);
            return distance <= HuntingProximity;
        }

        // Method to hunt down the player
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
