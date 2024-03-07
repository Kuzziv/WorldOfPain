using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Models.CharacterItems
{
    public class DefenceItem
    {
        public string Name { get; set; }
        public int ReduceHitPoit { get; set; }

        public DefenceItem(string name, int reduceHitPoit)
        {
            Name = name;
            ReduceHitPoit = reduceHitPoit;
        }
    }
}
