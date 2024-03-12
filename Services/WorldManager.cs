using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfPain.Models;
using WorldOfPain.Models.Environment;

namespace WorldOfPain.Services
{
    public class WorldManager
    {
        private bool _isGameOver = false;
        private World _world;
        private int _worldTurnCount = 0;

        public WorldManager(World world)
        {
            _world = world;
        }


        public void CreateWorld()
        {
            Console.Clear(); // Clear console before starting the game
            Console.WriteLine("Game Started");
            PrintGameMap(); // Print initial game map
        }


        public void UpdateWorld() 
        {
            PlayerTurn();
            PrintGameMap(); // Print game map after player's turn

            // Perform creatures' turn
            CreaturesTurn();
            PrintGameMap(); // Print game map after creatures' turn

            // Check for game over conditions
            CheckGameOver();

            // Increment turn count
            _worldTurnCount++;
        }

        public void runGame()
        {
            CreateWorld();

            while (!_isGameOver)
            {
                UpdateWorld();
            }
        }

        private void PrintGameMap()
        {
            Console.Clear(); // Clear console before printing new map

            for (int y = 0; y < _world.MaxY; y++)
            {
                for (int x = 0; x < _world.MaxX; x++)
                {
                    // Get the content of the square
                    string squareContent = _world.GetSquareContent(x, y);

                    // Print the square content with a space separator
                    Console.Write(squareContent + " ");
                }
                // Move to the next line for the next row
                Console.WriteLine();
            }

            // Print player's health
            Console.WriteLine($"{_world.Player.Name}'s Health: {_world.Player.Health}");
            // Print turn count
            Console.WriteLine($"This world turn count: {_worldTurnCount}");
        }

        private void PlayerTurn()
        {
            // Allow the player to take actions during their turn
            // For simplicity, let's assume the player moves by entering direction commands

            Console.WriteLine("Enter direction (WASD):");
            string input = Console.ReadLine();

            int newX = _world.Player.X;
            int newY = _world.Player.Y;

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
                _world.Player.Move(newX, newY);
            }
            else
            {
                Console.WriteLine("Invalid move! You cannot move out of bounds.");
            }
        }

        private bool IsValidMove(int x, int y)
        {
            // Check if the new position is within the bounds of the world
            return x >= 0 && x < _world.MaxX && y >= 0 && y < _world.MaxY;
        }


        private bool IsValidPosition(int x, int y)
        {
            // Check if the new position is within the bounds of the world
            return x >= 0 && x < _world.MaxX && y >= 0 && y < _world.MaxY;
        }

        private void CreaturesTurn()
        {
            // Allow creatures to take their actions during their turn
            // For each creature, check if player is within hunting proximity and perform appropriate actions
            foreach (var creature in _world.Creatures)
            {
                creature.HuntPlayer(_world.Player.X, _world.Player.Y);
                creature.AttackPlayer(_world.Player); // Creature attacks player if in range
            }
        }

        private void CheckGameOver()
        {
            // Check for conditions that lead to game over
            // For example, if player's health reaches zero
            if (_world.Player.Health <= 0)
            {
                _isGameOver = true;
                Console.WriteLine("Game Over! Player has been defeated.");
            }
        }









    }
}
