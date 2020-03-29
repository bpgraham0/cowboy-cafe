using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {

        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void CornDodgersImplementsINotifyPropertyChanged()
        {
            var cornDodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cornDodgers);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Calories", () => {
                cornDodgers.Size = Size.Medium;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Price", () => {
                cornDodgers.Size = Size.Medium;
            });
        }
    }
}
