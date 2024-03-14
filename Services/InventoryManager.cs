using System;
using System.Linq;
using WorldOfPain.Models.Character;
using WorldOfPain.Models.CharacterItems;

namespace WorldOfPain.Services
{
    /// <summary>
    /// Represents a manager responsible for managing the inventory of a hero.
    /// </summary>
    public class InventoryManager
    {
        /// <summary>
        /// Adds an item to the hero's bag.
        /// </summary>
        /// <param name="hero">The hero whose bag will receive the item.</param>
        /// <param name="item">The item to be added to the bag.</param>
        /// <exception cref="Exception">Thrown when the bag is full.</exception>
        public void AddItemToBag(Hero hero, ItemBase item)
        {
            if (hero.Bag.CurrentSlotsOccupied >= hero.Bag.MaxSlots)
            {
                throw new Exception("Bag is full");
            }

            hero.Bag.AddItem(item);
            Console.WriteLine($"{hero.Name} added {item.Name} to their bag.");
        }

        /// <summary>
        /// Removes an item from the hero's bag.
        /// </summary>
        /// <param name="hero">The hero whose bag contains the item to be removed.</param>
        /// <param name="item">The item to be removed from the bag.</param>
        /// <exception cref="Exception">Thrown when the item is not in the hero's bag.</exception>
        public void RemoveItemFromBag(Hero hero, ItemBase item)
        {
            if (!hero.Bag.Items.Contains(item))
            {
                throw new Exception($"{item.Name} is not in {hero.Name}'s bag.");
            }

            hero.Bag.RemoveItem(item);
            Console.WriteLine($"{hero.Name} removed {item.Name} from their bag.");
        }

        /// <summary>
        /// Lists the items contained in the hero's bag.
        /// </summary>
        /// <param name="hero">The hero whose bag contents will be listed.</param>
        public void ListItemsInBag(Hero hero)
        {
            Console.WriteLine($"{hero.Name}'s Bag Contents:");
            foreach (var item in hero.Bag.Items)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }
    }
}
