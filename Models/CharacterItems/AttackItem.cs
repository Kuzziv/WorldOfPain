using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Models.CharacterItems
{
    public class AttackItem : ItemBase
    {
        public int Hit { get; set; }

        public int Range { get; set; }

        public AttackItem(string name, int hit, int range)
            : base(name)
        {
            Hit = hit;
            Range = range;
        }





    }
}
