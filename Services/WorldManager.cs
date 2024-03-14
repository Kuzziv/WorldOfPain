using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfPain.Models;
using WorldOfPain.Models.Character;
using WorldOfPain.Models.Environment;

namespace WorldOfPain.Services
{
    /// <summary>
    /// Manages the game world, including player actions, creature behavior, and game state.
    /// </summary>
    public class WorldManager
    {
        private bool _isGameOver = false;
        private World _world;
        private int _worldTurnCount = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldManager"/> class with the specified world.
        /// </summary>
        /// <param name="world">The game world.</param>
        public WorldManager(World world)
        {
            _world = world;
        }

        /// <summary>
        /// Adds the hero to the game world.
        /// </summary>
        /// <param name="hero">The hero character.</param>
        public void AddHero(Hero hero)
        {
            _world.Player = hero;
        }

        /// <summary>
        /// Creates the game world and starts the game.
        /// </summary>
        public void CreateWorld()
        {
            Console.Clear(); // Clear console before starting the game
            Console.WriteLine("Game Started");
            PrintGameMap(); // Print initial game map
        }

        /// <summary>
        /// Updates the game world for the current turn.
        /// </summary>
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

        /// <summary>
        /// Runs the game loop until the game is over.
        /// </summary>
        public void runGame()
        {
            CreateWorld();

            while (!_isGameOver)
            {
                UpdateWorld();
            }
        }

        /// <summary>
        /// Prints the current game map to the console.
        /// </summary>
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

        /// <summary>
        /// Allows the player to take actions during their turn.
        /// </summary>
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

        /// <summary>
        /// Checks if a move to the specified position is valid.
        /// </summary>
        /// <param name="x">The X-coordinate of the position.</param>
        /// <param name="y">The Y-coordinate of the position.</param>
        /// <returns>True if the move is valid, otherwise false.</returns>
        private bool IsValidMove(int x, int y)
        {
            // Check if the new position is within the bounds of the world
            return x >= 0 && x < _world.MaxX && y >= 0 && y < _world.MaxY;
        }

        /// <summary>
        /// Performs actions for creatures during their turn.
        /// </summary>
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

        /// <summary>
        /// Checks for game over conditions and ends the game if necessary.
        /// </summary>
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
