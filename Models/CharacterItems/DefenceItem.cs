using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Models.CharacterItems
{
    public class DefenceItem : ItemBase
    {
        public int ReduceHitPoit { get; set; }

        public DefenceItem(string name, int reduceHitPoit)
            : base(name)
        {
            ReduceHitPoit = reduceHitPoit;
        }






    }
}
