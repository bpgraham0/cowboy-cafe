/* Author: Ben Graham
 * Class: BillControl.xaml.cs
 * Purpose: Handles denomination and quantity for bills
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
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        public BillControl()
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
            typeof(Bills),                          //type of property
            typeof(BillControl),                    //Property's control
            new PropertyMetadata(Bills.One)       //The property metadata
            );

        /// <summary>
        /// denomination of the bill
        /// </summary>
        public Bills Denomination
        {
            get
            {
                return (Bills)GetValue(DenominationProperty);
            }
            set
            {
                SetValue(DenominationProperty, value);
            }
        }

        /// <summary>
        /// the DependencyProperty backing the Quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register(
            "Quantity",
            typeof(int),
            typeof(BillControl),
            new FrameworkPropertyMetadata(
                0,
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                )
            );

        /// <summary>
        /// quantity of bill denomination
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
        /// Increases the quantity of the bound billage by one
        /// </summary>
        /// <param name="sender">The billage quanity (as an int)</param>
        /// <param name="args">The event args</param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Decreases the quantity of the bound billage by one
        /// </summary>
        /// <param name="sender">The Billage quanity (as an int)</param>
        /// <param name="args">The event args</param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }

    }
}
