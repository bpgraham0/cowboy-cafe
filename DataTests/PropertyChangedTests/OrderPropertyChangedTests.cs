using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class OrderPropertyChangedTests
    {
        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void OrderImplementsINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void AddingItemShouldInvokePropertyChangedForItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Add(item);
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void AddingItemShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(item);
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void RemovingItemShouldInvokePropertyChangedForItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Remove(item);
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void RemovingItemShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(item);
            });
        }
    }
}
