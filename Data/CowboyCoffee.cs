 /* Author: Ben Graham
 * Class: CowboyCoffee.cs
 * Purpose: Information about cowboy coffee
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink, INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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
        /// private backing variable
        /// </summary>
        private bool decaf;
        /// <summary>
        /// if coffee is decaf
        /// </summary>
        public bool Decaf {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        
        /// <summary>
        /// private backing variable
        /// </summary>
        private bool roomForCream;
        /// <summary>
        /// if coffee has cream
        /// </summary>
        public bool RoomForCream {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// private backing for ice
        /// </summary>
        private bool ice;
        /// <summary>
        /// if coffee has ice
        /// </summary>
        public override bool Ice {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

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

        /// <summary>
        /// Adds Water to order list
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            if (Decaf) return Size.ToString() + " Decaf Cowboy Coffee";


            return  Size.ToString() + " Cowboy Coffee";
        }

        /// <summary>
        /// gets just the name of item
        /// </summary>
        /// <returns>name of item</returns>
        public override string Name()
        {
            return "Cowboy Coffee";
        }

    }
}
