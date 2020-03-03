/* Author: Ben Graham
 * Class: JerkedSoda.cs
 * Purpose: Information about JerkedSoda
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// jerked soda price
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// jerked soda calories based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// gets flavor from enum class
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// hold info on ice
        /// </summary>
        public override bool Ice { get; set; } = true;

        /// <summary>
        /// info on special instrucitons
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;

            }
        }

        /// <summary>
        /// Adds Jerked Soda to order list
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            if(Flavor == SodaFlavor.BirchBeer)
            {
                return Size.ToString() + " " + "Birch Beer Jerked Soda";

            }
            else if (Flavor == SodaFlavor.CreamSoda)
            {
                return Size.ToString() + " " + "Cream Soda Jerked Soda";

            }
            else if (Flavor == SodaFlavor.OrangeSoda)
            {
                return Size.ToString() + " " + "Orange Soda Jerked Soda";

            }
            else if (Flavor == SodaFlavor.RootBeer)
            {
                return Size.ToString() + " " + "Root Beer Jerked Soda";

            }
            else
            {
                return Size.ToString() + " " + Flavor.ToString() + " Jerked Soda";

            }
        }

    }
}
