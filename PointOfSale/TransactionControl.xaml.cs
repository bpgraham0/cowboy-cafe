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
using PointOfSale.ExtensionMethods;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {


        public TransactionControl()
        {
            InitializeComponent();
        }


        private void CashButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreditButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CardTerminal terminal = new CardTerminal();

            ResultCode result = terminal.ProcessTransaction((orderControl.DataContext as Order).Total);

            if(result == ResultCode.Success)
            {
                ReceiptPrinter receiptPrinter = new ReceiptPrinter();
                Order order = (this.DataContext as Order);
                receiptPrinter.Print
                    ("Date: " + DateTime.Now.ToString()+"\n"+
                    "Order: " + order.OrderNumber.ToString() + "\n" + 
                    order.Items.ToString()+"\n"+
                    "Subtotal: "+order.Subtotal.ToString()+"\n" +
                    "Total: "+order.Total.ToString()+ "\n"+
                    "Processed by Credit \n"
                    
                    );
                orderControl.DataContext = new Order();
                orderControl.Container.Child = new MenuItemSelectionControl();
            }
            else
            {
                ErrorTextBlock.Text = "ERROR! The transaction had a(n) " + result.ToString()+"!";
            }
            
        }

        private void CancelTransactionButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.DataContext = new Order();
            orderControl.Container.Child = new MenuItemSelectionControl();
        }
    }
}
