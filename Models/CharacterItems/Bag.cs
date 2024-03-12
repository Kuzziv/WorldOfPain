using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Models.CharacterItems
{
    public class Bag : ItemBase
    {
        public List<ItemBase> Items { get; set; }
        public int MaxSlots { get; set; }
        public int CurrentSlots { get { return Items.Count; } }

        public Bag(string name, int maxSlots)
            : base(name)
        {
            Items = new List<ItemBase>();
            MaxSlots = maxSlots;
        }

        public void AddItem(ItemBase item)
        {
            Items.Add(item);
        }

        public void RemoveItem(ItemBase item)
        {
            Items.Remove(item);
        }

    }
}
