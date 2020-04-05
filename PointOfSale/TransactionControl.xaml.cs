/* Author: Ben Graham
 * Class: TransactionControl.xaml.cs
 * Purpose: Handles the selection of transaction method
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
using PointOfSale.ExtensionMethods;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        /// <summary>
        /// initializes component
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// takes user to cash control where they can caryy out payment in cash
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">event args</param>
        private void CashButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CashRegisterControl control = new CashRegisterControl(orderControl);
            orderControl.Container.Child = control;
        }
        /// <summary>
        /// takes user to finish paying with credit
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">event args</param>
        private void CreditButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CardTerminal terminal = new CardTerminal();

            ResultCode result = terminal.ProcessTransaction((orderControl.DataContext as Order).Total);

            if(result == ResultCode.Success)
            {
                ReceiptPrinter receiptPrinter = new ReceiptPrinter();
                receiptPrinter.Print( ReceiptBuilder());
                orderControl.DataContext = new Order();
                orderControl.Container.Child = new MenuItemSelectionControl();
            }
            else
            {
                ErrorTextBlock.Text = "ERROR! The transaction had a(n) " + result.ToString()+"!";
            }
            
        }
        /// <summary>
        /// wipes the order and resets screen
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">sender</param>
        private void CancelTransactionButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.DataContext = new Order();
            orderControl.Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// private helper method that format's the order in the form of a recepipt
        /// </summary>
        /// <returns></returns>
        private string ReceiptBuilder()
        {
            StringBuilder sb = new StringBuilder();
            int space;
            Order order = (this.DataContext as Order);
            
            for (int i = 0; i < 45; i++)
            {
                sb.Append("_");
            }
            sb.Append("\n");

            sb.Append("Date: ");
            sb.Append(DateTime.Now.ToString());
            sb.Append("\n");

            sb.Append("Order ");
            sb.Append(order.OrderNumber.ToString());
            sb.Append(":\n");
            foreach (IOrderItem item in order.Items)
            {
                sb.Append(" -");
                sb.Append(item);
                space = SpaceCalculator(item.ToString().Length+2,(int)item.Price);
                for(int i = 0; i <space; i++)
                {
                    sb.Append(" ");
                }
                sb.AppendFormat("{0:C}\n",item.Price);
                if (item.SpecialInstructions != null)
                {
                    foreach (string instruction in item.SpecialInstructions)
                    {
                        sb.Append("    ");
                        sb.Append(instruction);
                        sb.Append("\n");
                    }
                }
                

            }
            for (int i = 0; i < 45; i++)
            {
                sb.Append(".");
            }
            sb.Append("\n");
            sb.Append("Subtotal:" );
            space = SpaceCalculator("Subtotal:".Length, (int)order.Subtotal);
            for (int i = 0; i < space; i++)
            {
                sb.Append(" ");
            }
            sb.AppendFormat("{0:C}\n", order.Subtotal);

            sb.Append("Total after 16% tax:");
            space = SpaceCalculator("Total after 16% tax:".Length, (int)order.Total);
            for (int i = 0; i < space; i++)
            {
                sb.Append(" ");
            }
            sb.AppendFormat("{0:C}\n", order.Total);
            sb.Append("Processed by: Credit\n");
            for (int i = 0; i < 45; i++)
            {
                sb.Append("_");
            }
            sb.Append("\n");

            
            return sb.ToString();
        }

        /// <summary>
        /// private helper for the recepit builder
        /// take's current string and price length and subtracts from a char limit of 40
        /// </summary>
        /// <param name="stringLength">string length</param>
        /// <param name="price">price of item/total</param>
        /// <returns>number of spaces to be printed</returns>
        private int SpaceCalculator(int stringLength, int price)
        {
            return (40 - stringLength - price.ToString().Length);
        }
    }
}
