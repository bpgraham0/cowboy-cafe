/* Author: Ben Graham
 * Class: ChiliCheeseFries.cs
 * Purpose: Information about Chili Cheese fries 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side, INotifyPropertyChanged
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
        /// calorie info
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// price info
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Adds ChiliCheese Fries to order list
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {

            return Size.ToString() + " Chili Cheese Fries";
        }
    }
}
