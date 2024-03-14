using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfPain.Config.ModelsSettings;

namespace WorldOfPain.Config
{
    public class Config
    {
        public WorldSettings WorldSettings { get; set; }
        public PlayerSettings PlayerSettings { get; set; }
        public CreatureSettings CreatureSettings { get; set; }
    }
}
