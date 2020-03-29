using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void TrailBurgerImplementsINotifyPropertyChanged()
        {
            var trailBurger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trailBurger);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Bun", () => {
                trailBurger.Bun = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged for special instrucitons
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Bun = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Pickle", () => {
                trailBurger.Pickle = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Pickle = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Ketchup", () => {
                trailBurger.Ketchup = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Ketchup = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Mustard", () => {
                trailBurger.Mustard = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Mustard = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Cheese", () => {
                trailBurger.Cheese = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Cheese = false;
            });
        }



    }
}
