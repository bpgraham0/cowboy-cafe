using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {

        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var bakedBeans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bakedBeans);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Calories", () => {
                bakedBeans.Size = Size.Medium;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Price", () => {
                bakedBeans.Size = Size.Medium;
            });
        }
    }
}
