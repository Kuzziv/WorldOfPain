using System;

namespace WorldOfPain.Models.CharacterItems
{
    /// <summary>
    /// Represents a defense item that reduces hit points or damage received by characters, derived from the <see cref="ItemBase"/> class.
    /// </summary>
    public class DefenceItem : ItemBase
    {
        /// <summary>
        /// Gets or sets the amount by which the defense item reduces hit points or damage received.
        /// </summary>
        public int ReduceHitPoint { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefenceItem"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the defense item.</param>
        /// <param name="reduceHitPoint">The amount by which the defense item reduces hit points or damage received.</param>
        public DefenceItem(string name, int reduceHitPoint)
            : base(name)
        {
            ReduceHitPoint = reduceHitPoint;
        }
    }
}
