using System;
using WorldOfPain.Models.Environment;

namespace WorldOfPain.Services
{
    public class GameManager
    {
        private bool isGameOver = false;
        private World world;
        private int turnCount = 0;

        public GameManager(World world)
        {
            this.world = world;
        }

        public void StartGame()
        {
            Console.WriteLine("Game started!");
            PrintGameMap(); // Print initial game map

            while (!isGameOver)
            {
                // Perform player's turn
                PlayerTurn();
                PrintGameMap(); // Print game map after player's turn

                // Perform creatures' turn
                CreaturesTurn();
                PrintGameMap(); // Print game map after creatures' turn

                // Check for game over conditions
                CheckGameOver();
                
                // Increment turn count
                turnCount++;
            }

            // Perform any end game logic here
        }

        private void PrintGameMap()
        {
            Console.Clear(); // Clear console before printing new map

            for (int y = 0; y < world.MaxY; y++)
            {
                for (int x = 0; x < world.MaxX; x++)
                {
                    // Get the content of the square
                    string squareContent = world.GetSquareContent(x, y);

                    // Print the square content with a space separator
                    Console.Write(squareContent + " ");
                }
                // Move to the next line for the next row
                Console.WriteLine();
            }

            // Print player's health
            Console.WriteLine($"Player Health: {world.Player.Health}");
            // Print turn count
            Console.WriteLine($"Turn: {turnCount}");
        }

        private void PlayerTurn()
        {
            // Allow the player to take actions during their turn
            // For simplicity, let's assume the player moves by entering direction commands

            Console.WriteLine("Enter direction (WASD):");
            string input = Console.ReadLine();

            int newX = world.Player.X;
            int newY = world.Player.Y;

            // Adjust player's position based on input
            switch (input.ToUpper())
            {
                case "W":
                    newY--;
                    break;
                case "A":
                    newX--;
                    break;
                case "S":
                    newY++;
                    break;
                case "D":
                    newX++;
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter W, A, S, or D.");
                    break;
            }

            // Check if the new position is valid and move the player
            if (IsValidMove(newX, newY))
            {
                world.Player.Move(newX, newY);
            }
            else
            {
                Console.WriteLine("Invalid move! You cannot move out of bounds.");
            }
        }

        private bool IsValidMove(int x, int y)
        {
            // Check if the new position is within the bounds of the world
            return x >= 0 && x < world.MaxX && y >= 0 && y < world.MaxY;
        }


        private bool IsValidPosition(int x, int y)
        {
            // Check if the new position is within the bounds of the world
            return x >= 0 && x < world.MaxX && y >= 0 && y < world.MaxY;
        }

        private void CreaturesTurn()
        {
            // Allow creatures to take their actions during their turn
            // For each creature, check if player is within hunting proximity and perform appropriate actions
            foreach (var creature in world.Creatures)
            {
                creature.HuntPlayer(world.Player.X, world.Player.Y);
                creature.AttackPlayer(world.Player); // Creature attacks player if in range
            }
        }

        private void CheckGameOver()
        {
            // Check for conditions that lead to game over
            // For example, if player's health reaches zero
            if (world.Player.Health <= 0)
            {
                isGameOver = true;
                Console.WriteLine("Game Over! Player has been defeated.");
            }
        }
    }
}
