using System;
using System.Linq;
using WorldOfPain.Models.Character;
using WorldOfPain.Models.CharacterItems;

namespace WorldOfPain.Services
{
    public class InventoryManager
    {
        public void AddItemToBag(Hero hero, ItemBase item)
        {
            if (hero.Bag.CurrentSlotsOccupied >= hero.Bag.MaxSlots)
            {
                throw new Exception("Bag is full");
            }

            hero.Bag.AddItem(item);
            Console.WriteLine($"{hero.Name} added {item.Name} to their bag.");
        }

        public void RemoveItemFromBag(Hero hero, ItemBase item)
        {
            if (!hero.Bag.Items.Contains(item))
            {
                throw new Exception($"{item.Name} is not in {hero.Name}'s bag.");
            }

            hero.Bag.RemoveItem(item);
            Console.WriteLine($"{hero.Name} removed {item.Name} from their bag.");
        }

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
