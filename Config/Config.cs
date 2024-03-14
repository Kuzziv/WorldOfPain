using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfPain.Config.ModelsSettings;

namespace WorldOfPain.Config
{
    /// <summary>
    /// Represents the configuration settings for the game.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Gets or sets the world settings.
        /// </summary>
        public WorldSettings WorldSettings { get; set; }

        /// <summary>
        /// Gets or sets the player settings.
        /// </summary>
        public PlayerSettings PlayerSettings { get; set; }

        /// <summary>
        /// Gets or sets the creature settings.
        /// </summary>
        public CreatureSettings CreatureSettings { get; set; }
    }
}
