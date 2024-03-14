using System;
using WorldOfPain.Interfaces;
using WorldOfPain.Models.Character;
using WorldOfPain.Models.CharacterItems;
using WorldOfPain.Models.Environment;

namespace WorldOfPain.Services
{
    /// <summary>
    /// Represents the game manager responsible for controlling the game flow.
    /// </summary>
    public class GameManager
    {
        private WorldManager _worldManager;
        private SaveManager _saveManagerHeros = new SaveManager("Heros");
        private Hero _hero;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameManager"/> class with the specified world.
        /// </summary>
        /// <param name="world">The world in which the game takes place.</param>
        public GameManager(World world)
        {
            _worldManager = new WorldManager(world);
        }

        /// <summary>
        /// Starts the game.
        /// </summary>
        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to World of Pain!");
            Console.WriteLine("You are a hero in a world of pain. You must fight to survive.");
            Console.WriteLine("You have a bag to store items you find on your journey.");
            Console.ReadLine();
            CreateHero();
            RunGame();
        }

        /// <summary>
        /// Creates a new hero for the player.
        /// </summary>
        public void CreateHero()
        {
            Hero newHero = new Hero();

            Bag startingBag = new Bag("Normal Bag", 4);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            newHero.Name = name;
            newHero.Health = 100;
            newHero.AttackDamage = 10;
            newHero.Defense = 5;
            newHero.X = 0;
            newHero.Y = 0;
            newHero.Bag = startingBag;
            _hero = newHero;
            _saveManagerHeros.Save<Hero>(_hero, _hero.Name);
            _worldManager.AddHero(_hero);
        }

        /// <summary>
        /// Runs the game.
        /// </summary>
        public void RunGame()
        {
            _worldManager.runGame();
        }

        /// <summary>
        /// Ends the game.
        /// </summary>
        public void EndGame()
        {
            Console.WriteLine("Game Over");
        }
    }
}
