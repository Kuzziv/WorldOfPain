using System;
using System.Collections.Generic;
using WorldOfPain.Models.Character;

namespace WorldOfPain.Models.Environment
{
    public class World
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public Hero Player { get; set; }

        public List<Creature> Creatures { get; set; }
        public List<WorldObject> Objects { get; set; }

        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
            Creatures = new List<Creature>();
            Objects = new List<WorldObject>();
        }

        public void AddCreature(Creature creature)
        {
            Creatures.Add(creature); // Add creature to the list of creatures
        }

        public void AddObject(WorldObject worldObject)
        {
            Objects.Add(worldObject);
        }

        public string GetSquareContent(int x, int y)
        {
            // Check if there's a creature at this position
            foreach (var creature in Creatures)
            {
                if (creature is Creature && creature.X == x && creature.Y == y)
                {
                    return "[C]";
                }
            }

            // Check if there's a hero at this position
            if (Player.X == x && Player.Y == y)
            {
                return "[H]";
            }

            // Check if there's an object at this position
            foreach (var obj in Objects)
            {
                if (obj.X == x && obj.Y == y)
                {
                    return "[O]";
                }
            }

            // If the square is not occupied, return an empty square
            return "[ ]";
        }
    }
}
