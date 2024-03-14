using System;
using System.Collections.Generic;

namespace WorldOfPain.Models.CharacterItems
{
    /// <summary>
    /// Represents a bag for storing items carried by characters in the game, derived from the <see cref="ItemBase"/> class.
    /// </summary>
    public class Bag : ItemBase
    {
        /// <summary>
        /// Gets or sets the list of items stored in the bag.
        /// </summary>
        public List<ItemBase> Items { get; set; }

        /// <summary>
        /// Gets the maximum number of slots available in the bag.
        /// </summary>
        public int MaxSlots { get; }

        /// <summary>
        /// Gets the current number of slots occupied in the bag.
        /// </summary>
        public int CurrentSlotsOccupied { get { return Items.Count; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bag"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the bag.</param>
        /// <param name="maxSlots">The maximum number of slots available in the bag.</param>
        public Bag(string name, int maxSlots)
            : base(name)
        {
            Items = new List<ItemBase>();
            MaxSlots = maxSlots;
        }

        /// <summary>
        /// Adds an item to the bag.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        public void AddItem(ItemBase item)
        {
            Items.Add(item);
        }

        /// <summary>
        /// Removes an item from the bag.
        /// </summary>
        /// <param name="item">The item to be removed.</param>
        public void RemoveItem(ItemBase item)
        {
            Items.Remove(item);
        }
    }
}
