/* Author: Ben Graham
 * Class: 
 * Purpose: Information about water
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
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
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Small:
                        return 0.12;
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
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Small:
                        return 0;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// if water has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// if ice is included
        /// </summary>
        public override bool Ice { get; set; } = true;

        /// <summary>
        /// instructions for water
        /// </summary>
        public override List<string> SpecialInstructions {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");


                return instructions;

            }
        }

        /// <summary>
        /// Adds Water to order list
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            
            return Size.ToString() + " Water";
        }

    }
}
