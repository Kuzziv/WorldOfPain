using System;

namespace WorldOfPain.Models.CharacterItems
{
    /// <summary>
    /// Represents an attack item that can be used by characters in the game, derived from the <see cref="ItemBase"/> class.
    /// </summary>
    public class AttackItem : ItemBase
    {
        /// <summary>
        /// Gets or sets the hit points or damage inflicted by the attack item.
        /// </summary>
        public int Hit { get; set; }

        /// <summary>
        /// Gets or sets the range of the attack item.
        /// </summary>
        public int Range { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttackItem"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the attack item.</param>
        /// <param name="hit">The hit points or damage inflicted by the attack item.</param>
        /// <param name="range">The range of the attack item.</param>
        public AttackItem(string name, int hit, int range)
            : base(name)
        {
            Hit = hit;
            Range = range;
        }
    }
}
