using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the RustlersRibs entree
    /// </summary>
    public class RustlersRibs
    {

        /// <summary>
        /// The price of the ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }
        
        /// <summary>
        /// returns empty list since no special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {

                var instructions = new List<string>();

                return instructions;
            }
        }

    }
}

