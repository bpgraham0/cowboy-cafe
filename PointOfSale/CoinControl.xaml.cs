/* Author: Ben Graham
 * Class: CoinContro.xaml.cs
 * Purpose: handles denomination and quantity for coins
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl 
    {
        public CoinControl()
        {
            InitializeComponent();

        }

        
        /// <summary>
        /// the DependencyProperty backing the Denomination property
        /// </summary>
        // Using a DependencyProperty as the backing store for the Denomination Property.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DenominationProperty = DependencyProperty.Register
            (
            "Denomination",                         //Name of property
            typeof(Coins),                          //type of property
            typeof(CoinControl),                    //Property's control
            new PropertyMetadata(Coins.Penny)       //The property metadata
            );

        /// <summary>
        /// denomination of the coin
        /// </summary>
        public Coins Denomination
        {
            get
            {
                return (Coins)GetValue(DenominationProperty);
            }
            set
            {
                SetValue(DenominationProperty, value);
            }
        }

        /// <summary>
        /// The DependencyProperty backing the Quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
                DependencyProperty.Register(
                    "Quantity",
                    typeof(int),
                    typeof(CoinControl),
                    new FrameworkPropertyMetadata(
                        0,
                        FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );


        /// <summary>
        /// quantity of coin denomination
        /// </summary>
        public int Quantity
        {
            get
            {
                return (int)GetValue(QuantityProperty);
            }
            set
            {
                SetValue(QuantityProperty, value);
            }
        }

        /// <summary>
        /// Increases the quantity of the bound coinage by one
        /// </summary>
        /// <param name="sender">The coinage quanity (as an int)</param>
        /// <param name="args">The event args</param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Decreases the quantity of the bound coinage by one
        /// </summary>
        /// <param name="sender">The coinage quanity (as an int)</param>
        /// <param name="args">The event args</param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }


    }
}
