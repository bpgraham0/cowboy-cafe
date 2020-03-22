/* Author: Ben Graham
 * Class: IOrderItem.cs
 * Purpose: Information about item being displayed
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// price for item
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// calories for item
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// instructions for item
        /// </summary>
        public List<string> SpecialInstructions { get;  }



    }
}
