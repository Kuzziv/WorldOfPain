using System;
using WorldOfPain.Models.Character;
using WorldOfPain.Models.CharacterItems;
using WorldOfPain.Models.Environment;

namespace WorldOfPain.Services
{
    public class GameManager
    {
        private WorldManager _worldManager;
        private SaveManager _saveManager = new SaveManager();
        private Hero _hero;

        public GameManager(World world)
        {
            _worldManager = new WorldManager(world);
        }

        // start the game
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
            _saveManager.Save<Hero>(_hero, _hero.Name);
            _worldManager.AddHero(_hero);
            
        }

        public void RunGame() 
        {
            _worldManager.runGame();
        }

        // end the game
        public void EndGame()
        {
            Console.WriteLine("Game Over");
        }


    }
}
