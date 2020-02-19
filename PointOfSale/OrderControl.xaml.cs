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

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());

        }

        private void PecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());

        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());

        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());

        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());

        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());

        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());

        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());

        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());

        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());

        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());

        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());

        }
    }
}
