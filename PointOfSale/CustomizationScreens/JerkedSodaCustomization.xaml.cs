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
namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// changes size property when clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void SmallSize_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                if (sender is Button button)
                {
                    data.Size = CowboyCafe.Data.Size.Small;

                    SmallSize.Background = Brushes.LightBlue;
                    MediumSize.Background = Brushes.White;
                    LargeSize.Background = Brushes.White;
                }
            }
        }
        /// <summary>
        /// changes size property when clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void MediumSize_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                if (sender is Button button)
                {
                    data.Size = CowboyCafe.Data.Size.Medium;
                    SmallSize.Background = Brushes.White;
                    MediumSize.Background = Brushes.LightBlue;
                    LargeSize.Background = Brushes.White;
                }
            }
        }
        /// <summary>
        /// changes size property when clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void LargeSize_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                if (sender is Button button)
                {
                    data.Size = CowboyCafe.Data.Size.Large;
                    SmallSize.Background = Brushes.White;
                    MediumSize.Background = Brushes.White;
                    LargeSize.Background = Brushes.LightBlue;
                }
            }
        }
        /// <summary>
        /// changes flavor property when clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void CreamSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                if (sender is Button button)
                {
                    data.Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;

                    CreamSoda.Background = Brushes.LightBlue;
                    OrangeSoda.Background = Brushes.White;
                    RootBeer.Background = Brushes.White;
                    BirchBeer.Background = Brushes.White;
                    Sarsparilla.Background = Brushes.White;
                }
            }
        }
        /// <summary>
        /// changes flavor property when clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void OrangeSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                if (sender is Button button)
                {
                    data.Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;

                    CreamSoda.Background = Brushes.White;
                    OrangeSoda.Background = Brushes.LightBlue;
                    RootBeer.Background = Brushes.White;
                    BirchBeer.Background = Brushes.White;
                    Sarsparilla.Background = Brushes.White;
                }
            }
        }
        /// <summary>
        /// changes flavor property when clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void RootBeer_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                if (sender is Button button)
                {
                    data.Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;

                    CreamSoda.Background = Brushes.White;
                    OrangeSoda.Background = Brushes.White;
                    RootBeer.Background = Brushes.LightBlue;
                    BirchBeer.Background = Brushes.White;
                    Sarsparilla.Background = Brushes.White;
                }
            }
        }
        /// <summary>
        /// changes flavor property when clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void BirchBeer_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                if (sender is Button button)
                {
                    data.Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;

                    CreamSoda.Background = Brushes.White;
                    OrangeSoda.Background = Brushes.White;
                    RootBeer.Background = Brushes.White;
                    BirchBeer.Background = Brushes.LightBlue;
                    Sarsparilla.Background = Brushes.White;
                }
            }
        }
        /// <summary>
        /// changes flavor property when clicked
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">argument</param>
        private void Sarsparilla_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                if (sender is Button button)
                {
                    data.Flavor = CowboyCafe.Data.SodaFlavor.Sarsparilla;

                    CreamSoda.Background = Brushes.White;
                    OrangeSoda.Background = Brushes.White;
                    RootBeer.Background = Brushes.White;
                    BirchBeer.Background = Brushes.White;
                    Sarsparilla.Background = Brushes.LightBlue;
                }
            }
        }

        
    }
}
