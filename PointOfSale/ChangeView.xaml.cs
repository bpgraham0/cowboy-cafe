/* Author: Ben Graham
 * Class: ChangeView.xaml.cs
 * Purpose: Handles showing user change and printing receipt
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
    /// Interaction logic for ChangeView.xaml
    /// </summary>
    public partial class ChangeView : UserControl
    {
        public ChangeView(OrderControl orderC,double change)
        {
            InitializeComponent();
            orderControl = orderC;
            ChangeDisplayText.Text = String.Format("Resulting Change: {0:C}", change);
            ReceiptPrinter receiptPrinter = new ReceiptPrinter();
            receiptPrinter.Print(ReceiptBuilder(change));

        }
        /// <summary>
        /// holds refrence to order control
        /// </summary>
        public OrderControl orderControl { get; set; }

        /// <summary>
        /// creates new order and changes screen back to menu selection
        /// </summary>
        /// <param name="sender">button </param>
        /// <param name="e">event args</param>
        private void NewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            orderControl.DataContext = new Order();
            orderControl.Container.Child = new MenuItemSelectionControl();
        }


        /// <summary>
        /// private helper method that formats the order in the form of a receipt
        /// </summary>
        /// <param name="change">change from transaction</param>
        /// <returns>string being printed</returns>
        private string ReceiptBuilder(double change)
        {
            StringBuilder sb = new StringBuilder();
            int space;
            Order order = (orderControl.DataContext as Order);

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
                space = spaceCalculator(item.ToString().Length + 2, (int)item.Price);
                for (int i = 0; i < space; i++)
                {
                    sb.Append(" ");
                }
                sb.AppendFormat("{0:C}\n", item.Price);
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
            sb.Append("Subtotal:");
            space = spaceCalculator("Subtotal:".Length, (int)order.Subtotal);
            for (int i = 0; i < space; i++)
            {
                sb.Append(" ");
            }
            sb.AppendFormat("{0:C}\n", order.Subtotal);

            sb.Append("Total after 16% tax:");
            space = spaceCalculator("Total after 16% tax:".Length, (int)order.Total);
            for (int i = 0; i < space; i++)
            {
                sb.Append(" ");
            }
            sb.AppendFormat("{0:C}\n", order.Total);
            sb.Append("Amount Paid:");
            space = spaceCalculator("Amount Paid:".Length, (int)order.Total);
            for (int i = 0; i < space; i++)
            {
                sb.Append(" ");
            }
            sb.AppendFormat("{0:C}\n", change);
            sb.Append("Processed by: Cash\n");
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
        private int spaceCalculator(int stringLength, int price)
        {
            return (40 - stringLength - price.ToString().Length);
        }
    }
}
