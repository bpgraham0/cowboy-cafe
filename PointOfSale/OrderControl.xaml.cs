/* Author: Ben Graham
 * Class: OrderControl.xaml.cs
 * Purpose: Handles the buttons at the top of user interface
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
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// initialized the order contol and associates the data context with the current order
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            var data = new Order();
            this.DataContext = data;
        }
        /// <summary>
        /// private backing for order controls main register
        /// </summary>
        private static CashRegisterModelView register = new CashRegisterModelView();

        /// <summary>
        /// public getter for Register
        /// </summary>
        public CashRegisterModelView Register
        {
            get
            {
                return register;
            }
        }

        /// <summary>
        /// will allow you to pull up the item selection
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// clears current order
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// completes the current order
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new TransactionControl();

        }           

        /// <summary>
        /// helper method that changes screen to passed in element
        /// </summary>
        /// <param name="element">Framework element</param>
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    } 
}
