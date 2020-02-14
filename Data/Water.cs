using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
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


        public bool Lemon { get; set; } = false;

        public override bool Ice { get; set; } = true;

        public override List<string> SpecialInstructions {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");


                return instructions;

            }
        }
        
    }
}
