/* Author: Ben Graham
 * Class: Side.cs
 * Purpose: Information about sides
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        
        /// <summary>
        /// generates list of special instructions
        /// </summary>
        public virtual List<string> SpecialInstructions { get; }
        
        //public virtual List<string> SpecialInstructions => new List<string>();

    }
}