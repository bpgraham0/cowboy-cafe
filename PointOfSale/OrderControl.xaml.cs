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
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
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
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CowpokeChili());
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new RustlersRibs());
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void PecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new PecosPulledPork());
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TrailBurger());
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new DakotaDoubleBurger());
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTripleBurger());
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new PanDeCampo());
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CornDodgers());
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new ChiliCheeseFries());
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new JerkedSoda());
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTea());
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CowboyCoffee());
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new Water());
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }

        }

        /// <summary>
        /// Adds item to OrderList upon clicking
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">arument</param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new Water());
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }

         //<ListBox x:Name="OrderListView" Background="White" ScrollViewer.VerticalScrollBarVisibility="Visible" HorizontalAlignment="Right" ScrollViewer.CanContentScroll="True" Height="396" Width="193" Margin="1,1,1,1"/>
        
    }
}
