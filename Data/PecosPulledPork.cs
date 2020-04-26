/* Author: Ben Graham
 * Class: PecosPulledPork.cs
 * Purpose: Information about pecos pulled pork
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the pulled pork entree
    /// </summary>
    public class PecosPulledPork : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private bool bread = true;
        /// <summary>
        /// If the pulled pork should come with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;

        /// <summary>
        /// If the pulled pork comes with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }

        }
        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }


        /// <summary>
        /// Special instructions for the preparation of the pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Adds Pecos Pulled Pork to order list
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

        /// <summary>
        /// gets just the name of item
        /// </summary>
        /// <returns>name of item</returns>
        public override string Name()
        {
            return this.ToString();
        }
    }
}

