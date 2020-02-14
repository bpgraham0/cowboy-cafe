using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
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

        public override bool Ice { get; set; } = true;
        public bool Sweet { get; set; } = true;

        public bool Lemon { get; set; } = false;

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
