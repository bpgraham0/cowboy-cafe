using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {

        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var texasTea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTea);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Ice", () => {
                texasTea.Ice = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Ice = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSweet()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Sweet", () => {
                texasTea.Sweet = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Sweet = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Lemon", () => {
                texasTea.Lemon = true;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Lemon = true;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Calories", () => {
                texasTea.Size = Size.Medium;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Price", () => {
                texasTea.Size = Size.Medium;
            });
        }

    }
}
