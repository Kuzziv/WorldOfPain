using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Config.ModelsSettings
{
    /// <summary>
    /// Represents settings related to the game world.
    /// </summary>
    public class WorldSettings
    {
        /// <summary>
        /// Gets or sets the maximum value of the X-coordinate in the game world.
        /// </summary>
        public int MaxX { get; set; }

        /// <summary>
        /// Gets or sets the maximum value of the Y-coordinate in the game world.
        /// </summary>
        public int MaxY { get; set; }
    }
}
