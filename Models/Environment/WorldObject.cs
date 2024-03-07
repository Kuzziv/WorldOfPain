using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Models.Environment
{
    public class WorldObject
    {
        public string Name { get; set; }
        public bool IsLootable { get; set; }
        public bool IsRemovable { get; set; }
        public int X { get; set; } // X-coordinate position in the world
        public int Y { get; set; } // Y-coordinate position in the world

        public WorldObject(string name, bool isLootable, bool isRemovable)
        {
            Name = name;
            IsLootable = isLootable;
            IsRemovable = isRemovable;
        }

        // Randomly generate a position for the object
        public void GenerateRandomPosition(int maxX, int maxY)
        {
            Random random = new Random();
            X = random.Next(0, maxX);
            Y = random.Next(0, maxY);
        }

        public void Interact()
        {
            // Implement logic for interacting with the object
            // For example, picking up an item or triggering an event
        }
    }
}
