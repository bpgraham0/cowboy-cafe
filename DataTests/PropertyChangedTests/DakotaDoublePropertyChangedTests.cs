using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class DakotaDoublePropertyChangedTests
    {
        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void DakotaDoubleBurgerImplementsINotifyPropertyChanged()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakotaDouble);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Bun", () => {
                dakotaDouble.Bun = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged for special instrucitons
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Bun = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Pickle", () => {
                dakotaDouble.Pickle = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Pickle = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Ketchup", () => {
                dakotaDouble.Ketchup = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Ketchup = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Mustard", () => {
                dakotaDouble.Mustard = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Mustard = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Cheese", () => {
                dakotaDouble.Cheese = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Cheese = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Tomato", () => {
                dakotaDouble.Tomato = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Tomato = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Lettuce", () => {
                dakotaDouble.Lettuce = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Lettuce = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Mayo", () => {
                dakotaDouble.Mayo = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Mayo = false;
            });
        }


    }
}
