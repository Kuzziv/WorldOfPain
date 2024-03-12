using System;
using WorldOfPain.Models.Environment;

namespace WorldOfPain.Services
{
    public class GameManager
    {
        private WorldManager _worldManager;

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
            RunGame();
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
