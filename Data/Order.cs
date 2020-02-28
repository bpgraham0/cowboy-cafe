using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrderNumber;

        private List<IOrderItem> items = new List<IOrderItem>();

        public uint OrderNumber { get; } = lastOrderNumber + 1;

        public event PropertyChangedEventHandler PropertyChanged;

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

        public IEnumerable<IOrderItem> Items =>items;

        public void Add(IOrderItem item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        public void Remove (IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

        }
    }
}
