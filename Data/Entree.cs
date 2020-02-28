/* Author: Ben Graham
 * Class: Entree.cs
 * Purpose: Information about generic entrees 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the list of special instructions for the entree
        /// </summary>
        public virtual List<string> SpecialInstructions { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
    }
}
