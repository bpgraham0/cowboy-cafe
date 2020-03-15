/* Author: Ben Graham
 * Class: MenuItemSelectionControl.xaml.cs
 * Purpose: holds functions of food item buttons
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
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;
using System.Linq;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new AngryChicken());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new AngryChicken();
            var screen = new AngryChickenCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);
        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CowpokeChili());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new RustlersRibs());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new RustlersRibs();
            var screen = new RustlersRibsCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void PecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new PecosPulledPork());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new PecosPulledPork();
            var screen = new PecosPulledPorkCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TrailBurger());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new TrailBurger();
            var screen = new TrailBurgerCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new DakotaDoubleBurger());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new DakotaDoubleBurger();
            var screen = new DakotaDoubleBurgerCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTripleBurger());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new TexasTripleBurger();
            var screen = new TexasTripleBurgerCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new PanDeCampo());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CornDodgers());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new ChiliCheeseFries());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new Water());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new BakedBeans();
            var screen = new BakedBeansCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);
        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new JerkedSoda());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTea());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new TexasTea();
            var screen = new TexasTeaCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CowboyCoffee());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new Water());
            var orderControl = this.FindAncestor<OrderControl>();
            var item = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
            }
            orderControl?.SwapScreen(screen);

        }

        
    }
}
