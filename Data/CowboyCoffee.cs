/* Author: Ben Graham
 * Class: CowboyCoffee.cs
 * Purpose: Information about cowboy coffee
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// holds price info
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return .60;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// holds calorie info
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// if coffee is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// if coffee has cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// if coffee has ice
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// list of instructions
        /// </summary>
        public override List<string> SpecialInstructions {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                if (Decaf) instructions.Add("Decaf");
                return instructions;
            }
        }
        
    }
}
