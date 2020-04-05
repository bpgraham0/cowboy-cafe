/* Author: Ben Graham
 * Class: Order.cs
 * Purpose: Information about an Order object
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// holds info on Order objects
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// holds value of previous order 
        /// </summary>
        private static uint lastOrderNumber = 1;

        /// <summary>
        /// list of items in order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// holds order number and increments from previous
        /// </summary>
        public uint OrderNumber { get; } = lastOrderNumber ++;

        /// <summary>
        /// event that occurs if a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// subtotal that add's item prices
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach (IOrderItem item in items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        /// <summary>
        /// holds value of subtotal * 1.16 tax
        /// </summary>
        public double Total
        {
            get
            {
                double i = Subtotal * 1.16;
                return Convert.ToDouble(String.Format("{0:0.##}",i));
            }
        }
        
        /// <summary>
        /// generates list of special instructions
        /// </summary>
        public IEnumerable<IOrderItem> Items =>items.ToArray();

        /// <summary>
        /// updates items and subtotal if item is added
        /// </summary>
        /// <param name="item">item that's changed</param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            //fix
            if(item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged += OnItemChanged;
          
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));

        }

        /// <summary>
        /// updates list of items and subtotal if item is removed
        /// </summary>
        /// <param name="item">item being removed</param>
        public void Remove (IOrderItem item)
        {
            items.Remove(item);
            //fix
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged -= OnItemChanged;

            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));


        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
             

        }
    }
}
