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
    /// Interaction logic for CornDodgersCustomization.xaml
    /// </summary>
    public partial class CornDodgersCustomization : UserControl
    {
        public CornDodgersCustomization()
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
            if (DataContext is CornDodgers data)
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
            if (DataContext is CornDodgers data)
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
            if (DataContext is CornDodgers data)
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
    }
}
