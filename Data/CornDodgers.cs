﻿/* Author: Ben Graham
 * Class: CornDodgers.cs
 * Purpose: Information about corn dodgers
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CornDodgers : Side
    {
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
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

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
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }


        /// <summary>
        /// Adds Corn Dodgers to order list
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {

            return Size.ToString() + " Corn Dodgers";
        }
    }
}
