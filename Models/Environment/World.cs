using System;
using System.Collections.Generic;
using WorldOfPain.Models.Character;

namespace WorldOfPain.Models.Environment
{
    /// <summary>
    /// Represents the game world where characters and objects exist.
    /// </summary>
    public class World
    {
        /// <summary>
        /// Gets or sets the maximum value for the X coordinate of the world.
        /// </summary>
        public int MaxX { get; set; }

        /// <summary>
        /// Gets or sets the maximum value for the Y coordinate of the world.
        /// </summary>
        public int MaxY { get; set; }

        /// <summary>
        /// Gets or sets the player character in the world.
        /// </summary>
        public Hero Player { get; set; }

        /// <summary>
        /// Gets or sets the list of creatures present in the world.
        /// </summary>
        public List<Creature> Creatures { get; set; }

        /// <summary>
        /// Gets or sets the list of objects present in the world.
        /// </summary>
        public List<WorldObject> Objects { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="World"/> class with specified parameters.
        /// </summary>
        /// <param name="maxX">The maximum value for the X coordinate of the world.</param>
        /// <param name="maxY">The maximum value for the Y coordinate of the world.</param>
        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
            Creatures = new List<Creature>();
            Objects = new List<WorldObject>();
        }

        /// <summary>
        /// Adds a creature to the world.
        /// </summary>
        /// <param name="creature">The creature to add.</param>
        public void AddCreature(Creature creature)
        {
            Creatures.Add(creature); // Add creature to the list of creatures
        }

        /// <summary>
        /// Adds an object to the world.
        /// </summary>
        /// <param name="worldObject">The object to add.</param>
        public void AddObject(WorldObject worldObject)
        {
            Objects.Add(worldObject);
        }

        /// <summary>
        /// Gets the content of the square at the specified coordinates.
        /// </summary>
        /// <param name="x">The X coordinate of the square.</param>
        /// <param name="y">The Y coordinate of the square.</param>
        /// <returns>A string representing the content of the square.</returns>
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
