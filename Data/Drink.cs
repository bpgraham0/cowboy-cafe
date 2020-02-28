/* Author: Ben Graham
 * Class: Drink.cs
 * Purpose: Information about generic drinks
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink :IOrderItem
    {
        /// <summary>
        /// initalizes size to small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the list of special instructions for the drink
        /// </summary>
        public virtual List<string> SpecialInstructions { get; set; }
    }
}
