using System;

namespace WorldOfPain.Models.Environment
{
    /// <summary>
    /// Represents an object in the game world.
    /// </summary>
    public class WorldObject
    {
        /// <summary>
        /// Gets or sets the name of the world object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the object can be looted.
        /// </summary>
        public bool IsLootable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the object can be removed from the world.
        /// </summary>
        public bool IsRemovable { get; set; }

        /// <summary>
        /// Gets or sets the X-coordinate position of the object in the world.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate position of the object in the world.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldObject"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the world object.</param>
        /// <param name="isLootable">A value indicating whether the object can be looted.</param>
        /// <param name="isRemovable">A value indicating whether the object can be removed from the world.</param>
        public WorldObject(string name, bool isLootable, bool isRemovable)
        {
            Name = name;
            IsLootable = isLootable;
            IsRemovable = isRemovable;
        }

        /// <summary>
        /// Generates a random position for the object within the specified bounds.
        /// </summary>
        /// <param name="maxX">The maximum value for the X-coordinate position in the world.</param>
        /// <param name="maxY">The maximum value for the Y-coordinate position in the world.</param>
        public void GenerateRandomPosition(int maxX, int maxY)
        {
            Random random = new Random();
            X = random.Next(0, maxX);
            Y = random.Next(0, maxY);
        }

        /// <summary>
        /// Performs an interaction with the object.
        /// </summary>
        public void Interact()
        {
            // Implement logic for interacting with the object
            // For example, picking up an item or triggering an event
        }
    }
}
