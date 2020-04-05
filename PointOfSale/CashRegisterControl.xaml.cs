/* Author: Ben Graham
 * Class: CashRegisterControl.xaml.cs
 * Purpose: handles input for cash register 
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        /// <summary>
        /// initalizes xaml, adds the order control, clears the drawer, add's the listener, and format's the textboxes
        /// </summary>
        /// <param name="orderC">ordercontrol passed from transaction control</param>
        public CashRegisterControl(OrderControl orderC)
        {
            InitializeComponent();
            orderControl = orderC;
            ClearDrawer();
            (DataContext as CashRegisterModelView).TotalValueChanged += new EventHandler(updateTotal);
            TargetTotalText.Text = String.Format("Enter cash to pay the Order Total: {0:C}",TargetTotal);
            GoalTotalText.Text = String.Format("Cash entered so far: {0:C}", (DataContext as CashRegisterModelView).TotalValue);


        }
        /// <summary>
        /// holds refrence to the orderCOntrol
        /// </summary>
        public OrderControl orderControl { get; set; }

        /// <summary>
        /// holds value of order total
        /// </summary>
        public double TargetTotal { 
            get
            {
                double total = (orderControl.DataContext as Order).Total;
                return Convert.ToDouble(String.Format("{0:C}",total.ToString()));
            }

        }

       /// <summary>
       /// updates total on xaml
       /// </summary>
       /// <param name="sender">event from CashRegisterModelView</param>
       /// <param name="e">event args</param>
        public void updateTotal(object sender, EventArgs e)
        {
            GoalTotalText.Text = String.Format("Cash entered so far: {0:C}", (DataContext as CashRegisterModelView).TotalValue);

        }

        /// <summary>
        /// holds value of cash in current register
        /// </summary>
        public double Total
        {
            get {
                GoalTotalText.Text = String.Format("Cash entered so far: {0:C}", (DataContext as CashRegisterModelView).TotalValue);
                return (DataContext as CashRegisterModelView).TotalValue; }
            
        }

        /// <summary>
        /// helper method that empties drawer of current register
        /// </summary>
        private void ClearDrawer()
        {
            CashRegisterModelView register = new CashRegisterModelView();
            register.Pennies = 0;
            register.Nickels = 0;
            register.Dimes = 0;
            register.Quarters = 0;
            register.HalfDollars = 0;
            register.Dollars = 0;
            register.Ones = 0;
            register.Twos = 0;
            register.Fives = 0;
            register.Tens = 0;
            register.Twenties = 0;
            register.Fifties = 0;
            register.Hundreds = 0;
            DataContext = register;

        }

        /// <summary>
        /// Handles computation between cash inputed and order total, along with handling change
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">event args</param>
        private void CompleteTransaction_Click(object sender, RoutedEventArgs e)
        {
            if (Total < TargetTotal)
            {
                ErrorMessageText.Text = "Insufficient amount entered. Please insert more.";
            }
            else
            {
                decimal tempChange = Convert.ToDecimal(String.Format("{0:0.##}", Total))  - Convert.ToDecimal(String.Format("{0:0.##}", TargetTotal));
                double change = Convert.ToDouble(tempChange);
                double endChange = change;
                CashRegisterModelView register = (DataContext as CashRegisterModelView);
                orderControl.Register.AddCoin(Coins.Penny, register.Pennies);
                orderControl.Register.AddCoin(Coins.Nickel, register.Nickels);
                orderControl.Register.AddCoin(Coins.Dime, register.Dimes);
                orderControl.Register.AddCoin(Coins.Quarter, register.Quarters);
                orderControl.Register.AddCoin(Coins.HalfDollar, register.HalfDollars);
                orderControl.Register.AddCoin(Coins.Dollar, register.Dollars);

                orderControl.Register.AddBill(Bills.One, register.Ones);
                orderControl.Register.AddBill(Bills.Two, register.Twos);
                orderControl.Register.AddBill(Bills.Five, register.Fives);
                orderControl.Register.AddBill(Bills.Ten, register.Tens);
                orderControl.Register.AddBill(Bills.Twenty, register.Twenties);
                orderControl.Register.AddBill(Bills.Fifty, register.Fifties);
                orderControl.Register.AddBill(Bills.Hundred, register.Hundreds);

                ClearDrawer();
                register = (DataContext as CashRegisterModelView);
                CashRegisterModelView tempRegister = register;
                CashRegisterModelView tempMainRegister = orderControl.Register;
                try
                {
                    while (change >= .01)
                    {
                        if (change >= 100 && orderControl.Register.Hundreds > 0)
                        {
                            register.AddBill(Bills.Hundred, 1);
                            change -= 100;
                            orderControl.Register.RemoveBill(Bills.Hundred, 1);

                        }
                        else if (change >= 50 && orderControl.Register.Fifties > 0)
                        {
                            register.AddBill(Bills.Fifty, 1);
                            change -= 50;
                            orderControl.Register.RemoveBill(Bills.Fifty, 1);

                        }
                        else if (change >= 20 && orderControl.Register.Twenties > 0)
                        {
                            register.AddBill(Bills.Twenty, 1);
                            change -= 20;
                            orderControl.Register.RemoveBill(Bills.Twenty, 1);

                        }
                        else if (change >= 10 && orderControl.Register.Tens > 0)
                        {
                            register.AddBill(Bills.Ten, 1);
                            change -= 10;
                            orderControl.Register.RemoveBill(Bills.Ten, 1);

                        }
                        else if (change >= 5 && orderControl.Register.Fives > 0)
                        {
                            register.AddBill(Bills.Five, 1);
                            change -= 5;
                            orderControl.Register.RemoveBill(Bills.Five, 1);

                        }
                        else if (change >= 2 && orderControl.Register.Twos > 0)
                        {
                            register.AddBill(Bills.Two, 1);
                            change -= 2;
                            orderControl.Register.RemoveBill(Bills.Two, 1);

                        }
                        else if (change >= 1 && orderControl.Register.Ones > 0)
                        {
                            register.AddBill(Bills.One, 1);
                            change -= 1;
                            orderControl.Register.RemoveBill(Bills.One, 1);

                        }
                        else if (change >= 1 && orderControl.Register.Dollars > 0)
                        {
                            register.AddCoin(Coins.Dollar, 1);
                            change -= 1;
                            orderControl.Register.RemoveCoin(Coins.Dollar, 1);

                        }
                        else if (change >= .50 && orderControl.Register.HalfDollars > 0)
                        {
                            register.AddCoin(Coins.HalfDollar, 1);
                            change -= .50;
                            orderControl.Register.RemoveCoin(Coins.HalfDollar, 1);
                        }
                        else if (change >= .25 && orderControl.Register.Quarters > 0)
                        {
                            register.AddCoin(Coins.Quarter, 1);
                            change -= .25;
                            orderControl.Register.RemoveCoin(Coins.Quarter, 1);

                        }
                        else if (change >= .10 && orderControl.Register.Dimes > 0)
                        {
                            register.AddCoin(Coins.Dime, 1);
                            change -= .10;
                            orderControl.Register.RemoveCoin(Coins.Dime, 1);

                        }
                        else if (change >= .05 && orderControl.Register.Nickels > 0)
                        {
                            register.AddCoin(Coins.Nickel, 1);
                            change -= .05;
                            orderControl.Register.RemoveCoin(Coins.Nickel, 1);

                        }
                        else if (change >= .01 && orderControl.Register.Pennies > 0)
                        {
                            register.AddCoin(Coins.Penny, 1);
                            change -= .01;
                            orderControl.Register.RemoveCoin(Coins.Penny, 1);

                        }
                        else throw new DrawerOverdrawException();
                    }
                    ChangeView changeControl = new ChangeView(orderControl,endChange);
                    changeControl.DataContext = register;
                    orderControl.SwapScreen(changeControl);

                    
                }
                catch (DrawerOverdrawException)
                {
                    ErrorMessageText.Text = "ERROR, Insufficient funds in the register!";

                }
                
            }
        }
        

    }
}
