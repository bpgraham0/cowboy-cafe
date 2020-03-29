using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {

        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chiliCheeseFries);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheeseFries, "Calories", () => {
                chiliCheeseFries.Size = Size.Medium;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheeseFries, "Price", () => {
                chiliCheeseFries.Size = Size.Medium;
            });
        }
    }
}
