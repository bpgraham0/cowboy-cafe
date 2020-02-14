/* Author: Ben Graham
 * Class: 
 * Purpose: Information about texas tea
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
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
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// calorie info
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
                
            }
        }
        /// <summary>
        /// ice info
        /// </summary>
        public override bool Ice { get; set; } = true;
        /// <summary>
        /// holds sweet info
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// whether tea has lemon or not
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// list of instructions
        /// </summary>
        public override List<string> SpecialInstructions 
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                if (!Sweet) instructions.Add("Unsweet");

                return instructions;
            }
        }

     
        
    }
}
