using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {


        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void PanDeCampoImplementsINotifyPropertyChanged()
        {
            var panDeCampo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(panDeCampo);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Calories", () => {
                panDeCampo.Size = Size.Medium;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Price", () => {
                panDeCampo.Size = Size.Medium;
            });
        }
    }
}
