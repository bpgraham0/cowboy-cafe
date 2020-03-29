/* Author: Ben Graham
 * Class: OrderSummaryControl.xaml.cs
 * Purpose: Information about order controlS
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
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// upon selecting an item from the list box, changes to that item's screen
        /// </summary>
        /// <param name="sender">ListBox</param>
        /// <param name="e">event args</param>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null) return;
            object item = (sender as ListBox).SelectedItem;
            (sender as ListBox).SelectedItem = null;

            FrameworkElement screen = SwapScreenHelper(item);
            orderControl?.SwapScreen(screen);


        }

        /// <summary>
        /// finds the item and removes it from the order and sends screen back to menu item selection
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">event args</param>
        private void RemoveButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null) return;
            FrameworkElement screen = new MenuItemSelectionControl();
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    if (button.DataContext is IOrderItem item)
                    {
                        orderControl?.SwapScreen(screen);
                        data.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// takes in an item and finds the corresponding screen for it and then applies the context to it
        /// </summary>
        /// <param name="item">menu item</param>
        /// <returns>returns the screen with the context</returns>
        private FrameworkElement SwapScreenHelper(object item)
        {
            FrameworkElement screen = new MenuItemSelectionControl();
            if (item is AngryChicken)
            {
                screen = new AngryChickenCustomization();
                screen.DataContext = item;
            }
            else if (item is CowpokeChili)
            {
                screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
            }
            else if (item is RustlersRibs)
            {
                screen = new RustlersRibsCustomization();
                screen.DataContext = item;
            }
            else if (item is PecosPulledPork)
            {
                screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
            }
            else if (item is TrailBurger)
            {
                screen = new TrailBurgerCustomization();
                screen.DataContext = item;
            }
            else if (item is DakotaDoubleBurger)
            {
                screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = item;
            }
            else if (item is TexasTripleBurger)
            {
                screen = new TexasTripleBurgerCustomization();
                screen.DataContext = item;
            }
            else if (item is PanDeCampo)
            {
                screen = new PanDeCampoCustomization();
                screen.DataContext = item;
            }
            else if (item is CornDodgers)
            {
                screen = new CornDodgersCustomization();
                screen.DataContext = item;
            }
            else if (item is ChiliCheeseFries)
            {
                screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = item;
            }
            else if (item is BakedBeans)
            {
                screen = new BakedBeansCustomization();
                screen.DataContext = item;
            }
            else if (item is JerkedSoda)
            {
                screen = new JerkedSodaCustomization();
                screen.DataContext = item;
            }
            else if (item is CowboyCoffee)
            {
                screen = new CowboyCoffeeCustomization();
                screen.DataContext = item;
            }
            else if (item is TexasTea)
            {
                screen = new TexasTeaCustomization();
                screen.DataContext = item;
            }
            else if (item is Water)
            {
                screen = new WaterCustomization();
                screen.DataContext = item;
            }
            return screen;
        }
    }
}
