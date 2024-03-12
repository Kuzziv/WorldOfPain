using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Models.CharacterItems
{
    public abstract class ItemBase
    {
        public string Name { get; set; }

        public ItemBase(string name)
        {
            Name = name;
        }


    }
}
