/* Author: Ben Graham
 * Class: Water.cs
 * Purpose: Information about water
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    public class Water : Drink, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing variable
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// initalizes size to small
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialIngredients"));
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
        /// private backing for lemon
        /// </summary>
        private bool lemon;
        /// <summary>
        /// if water has lemon
        /// </summary>
        public bool Lemon {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialIngredients"));
            }
        }

        /// <summary>
        /// private backing for ice
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// if ice is included
        /// </summary>
        public override bool Ice {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialIngredients"));
            }
        }

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
