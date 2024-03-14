using System;

namespace WorldOfPain.Models.CharacterItems
{
    /// <summary>
    /// Represents a base class for items that can be used or carried by characters in the game.
    /// </summary>
    public abstract class ItemBase
    {
        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBase"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the item.</param>
        public ItemBase(string name)
        {
            Name = name;
        }
    }
}
