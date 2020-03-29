using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {

        /// <summary>
        /// checks if the class implements the INotifyProperty
        /// </summary>
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pecosPulledPork);
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pecosPulledPork, "Bread", () => {
                pecosPulledPork.Bread = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pecosPulledPork, "SpecialInstructions", () => {
                pecosPulledPork.Bread = false;
            });
        }

        /// <summary>
        /// checks if change in property invokes propertychanged
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pecosPulledPork, "Pickle", () => {
                pecosPulledPork.Pickle = false;
            });
        }



        /// <summary>
        /// checks if change in property invokes propertychanged for special instructions
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pecosPulledPork, "SpecialInstructions", () => {
                pecosPulledPork.Pickle = false;
            });
        }
    }
}
