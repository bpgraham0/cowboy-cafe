using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void CowpokeChiliImplementsINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

/// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () => {
                chili.Cheese = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => {
                chili.Cheese = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () => {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged for special instrucitons
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => {
                chili.SourCream = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () => {
                chili.GreenOnions = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => {
                chili.GreenOnions = false;
            });
        }


        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () => {
                chili.TortillaStrips = false;
            });
        }
        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => {
                chili.TortillaStrips = false;
            });
        }



        
    }
}
