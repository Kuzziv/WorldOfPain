using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfPain.Config.ModelsSettings
{
    /// <summary>
    /// Represents settings related to the player character in the game.
    /// </summary>
    public class PlayerSettings
    {
        /// <summary>
        /// Gets or sets the name of the player character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the initial health of the player character.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Gets or sets the attack damage of the player character.
        /// </summary>
        public int AttackDamage { get; set; }

        /// <summary>
        /// Gets or sets the defense of the player character.
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// Gets or sets the starting X-coordinate position of the player character.
        /// </summary>
        public int StartingX { get; set; }

        /// <summary>
        /// Gets or sets the starting Y-coordinate position of the player character.
        /// </summary>
        public int StartingY { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of slots in the player's bag.
        /// </summary>
        public int MaxBagSlots { get; set; }
    }
}
