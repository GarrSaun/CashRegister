///Garrett - Cash Register Program
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class calulatorForm : Form
    {
        //Global Variables
        double burgerCost;
        double friesCost;
        double drinksCost;
        double subTotal;
        double totalTax;
        double total;
        double change;
        int orderNumber;

        //Global Input Variables
        int burgers;
        int fries;
        int drinks;
        double amountTendered;

        //Global Constants
        const double BURGER_PRICE = 2.49;
        const double FRIES_PRICE = 1.89;
        const double DRINKS_PRICE = 0.99;
        const double TAX_RATE = 0.13;
        const int TIME = 250;
                  
        public calulatorForm()
        {
            InitializeComponent();
        }

        //Remove Text From Textboxes When Clicked
        private void burgerBox_Click(object sender, EventArgs e)
        {
            burgerBox.Text = "";
        }

        private void friesBox_Click(object sender, EventArgs e)
        {
            friesBox.Text = "";
        }

        private void drinkBox_Click(object sender, EventArgs e)
        {
            drinkBox.Text = "";
        }

        private void tenderedBox_Click(object sender, EventArgs e)
        {
            tenderedBox.Text = "";
        }

        //Calculate Cost with Tax
        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                    burgers = Convert.ToInt16(burgerBox.Text);
                    fries = Convert.ToInt16(friesBox.Text);
                    drinks = Convert.ToInt16(drinkBox.Text);

                    burgerCost = burgers * BURGER_PRICE;
                    friesCost = fries * FRIES_PRICE;
                    drinksCost = drinks * DRINKS_PRICE;

                    subTotal = burgerCost + friesCost
                        + drinksCost;
                    totalTax = (burgerCost + friesCost
                        + drinksCost) * TAX_RATE;
                    total = totalTax + subTotal;

                    totalLabel.Text = "Sub Total: " + subTotal.ToString("$0.00") + "\n" +
                        "Tax: " + totalTax.ToString("$0.00") + "\n" +
                        "Total: " + total.ToString("$0.00");
            }

            catch
            {
                totalLabel.Text = "Something went wrong. Try again!";
                return;
            }

        }

        //Calculate Change
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                amountTendered = Convert.ToDouble(tenderedBox.Text);

                change = amountTendered - total;

                if (change >= 0)
                {
                    changeLabel.Text = "Change: " + change.ToString("$0.00");

                    receiptButton.Visible = true;
                }
                else
                {
                    changeLabel.Text = "You need an extra " + (change*-1).ToString("$0.00") +
                        " to afford that.";
                }
            }

            catch
            {
                changeLabel.Text = "Something went wrong.";
                return;    
            }
        }

        //Receipt
        private void receiptButton_Click(object sender, EventArgs e)
        {
            //Sound
            SoundPlayer printPlayer = new SoundPlayer(Properties.Resources.print);
            printPlayer.Play();

            //Set up graphics
            Graphics onScreen = this.CreateGraphics();
            Bitmap bm = new Bitmap(this.Width, this.Height);
            Graphics offScreen = Graphics.FromImage(bm);
            Pen receiptPen = new Pen(Color.Black, 2);
            SolidBrush receiptBrush = new SolidBrush(Color.White);
            Font printFont = new Font("Segoe UI", 8, FontStyle.Bold);
            SolidBrush printBrush = new SolidBrush(Color.Black);

            //Draw receipt
            onScreen.Clear(Color.LightGray);

            orderNumber = orderNumber + 1;

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 25);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 25);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            Thread.Sleep(TIME); //1

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 50);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 50);
            offScreen.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            Thread.Sleep(TIME); //2

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 100);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 100);
            offScreen.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            offScreen.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            Thread.Sleep(TIME); //3

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 150);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 150);
            offScreen.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            offScreen.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            offScreen.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            Thread.Sleep(TIME); //4

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 200);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 200);
            offScreen.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            offScreen.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            offScreen.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            offScreen.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            Thread.Sleep(TIME); //5

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 250);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 250);
            offScreen.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            offScreen.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            offScreen.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            offScreen.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);
            offScreen.DrawString("Subtotal =" + subTotal.ToString("$0.00")
                , printFont, printBrush, 275, 260);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            Thread.Sleep(TIME); //6

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 300);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 300);
            offScreen.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            offScreen.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            offScreen.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            offScreen.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);
            offScreen.DrawString("Subtotal =" + subTotal.ToString("$0.00")
                , printFont, printBrush, 275, 260);
            offScreen.DrawString("Tax =" + totalTax.ToString("$0.00")
                , printFont, printBrush, 275, 310);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            Thread.Sleep(TIME); //7

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 350);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 350);
            offScreen.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            offScreen.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            offScreen.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            offScreen.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);
            offScreen.DrawString("Subtotal =" + subTotal.ToString("$0.00")
                , printFont, printBrush, 275, 260);
            offScreen.DrawString("Tax =" + totalTax.ToString("$0.00")
                , printFont, printBrush, 275, 310);
            offScreen.DrawString("Total =" + total.ToString("$0.00")
                , printFont, printBrush, 275, 360);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            Thread.Sleep(TIME); //8

            offScreen.DrawRectangle(receiptPen, 250, 30, 225, 400);
            offScreen.FillRectangle(receiptBrush, 250, 30, 225, 400);
            offScreen.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            offScreen.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            offScreen.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            offScreen.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);
            offScreen.DrawString("Subtotal =" + subTotal.ToString("$0.00")
                , printFont, printBrush, 275, 260);
            offScreen.DrawString("Tax =" + totalTax.ToString("$0.00")
                , printFont, printBrush, 275, 310);
            offScreen.DrawString("Total =" + total.ToString("$0.00")
                , printFont, printBrush, 275, 360);
            offScreen.DrawString("Amount Tendered =" + amountTendered.ToString("$0.00") + "\n" +
                "Change Due = " + change.ToString("$0.00"), printFont, printBrush, 275, 400);

            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.LightGray);

            newButton.Visible = true;
            receiptButton.Visible = false;
        }

        //New order
        private void newButton_Click(object sender, EventArgs e)
        {
            //Reset Input
            burgers = 0;
            fries = 0;
            drinks = 0;
            amountTendered = 0;

            burgerBox.Text = "0";
            friesBox.Text = "0";
            drinkBox.Text = "0";
            tenderedBox.Text = "0";

            //Reset Output
            burgerCost = 0;
            friesCost = 0;
            drinksCost = 0;
            subTotal = 0;
            totalTax = 0;
            total = 0;
            change = 0;

            totalLabel.Text = "";
            changeLabel.Text = "";

            newButton.Visible = false;
        }
    }
}

