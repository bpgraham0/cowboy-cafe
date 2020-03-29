using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTriple);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Bun", () => {
                texasTriple.Bun = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged for special instrucitons
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Bun = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Pickle", () => {
                texasTriple.Pickle = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Pickle = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Ketchup", () => {
                texasTriple.Ketchup = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Ketchup = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Mustard", () => {
                texasTriple.Mustard = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Mustard = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Cheese", () => {
                texasTriple.Cheese = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Cheese = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Tomato", () => {
                texasTriple.Tomato = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Tomato = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Lettuce", () => {
                texasTriple.Lettuce = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Lettuce = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Mayo", () => {
                texasTriple.Mayo = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Mayo = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Bacon", () => {
                texasTriple.Bacon = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Bacon = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Egg", () => {
                texasTriple.Egg = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () => {
                texasTriple.Egg = false;
            });
        }
    }
}
