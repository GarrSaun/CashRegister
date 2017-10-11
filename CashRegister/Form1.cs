///Garrett Cash Register Program
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

        //Global Variables That Need to be Calculated
        double burgerCost;
        double friesCost;
        double drinksCost;
        double subTotal;
        double totalTax;
        double total;
        double change;
        int orderNumber;


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

                changeLabel.Text = "Change: " + change.ToString("$0.00");

                receiptButton.Visible = true;
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
            Graphics fg = this.CreateGraphics();
            Pen receiptPen = new Pen(Color.Black, 2);
            SolidBrush receiptBrush = new SolidBrush(Color.White);
            Font printFont = new Font("Segoe UI", 8, FontStyle.Bold);
            SolidBrush printBrush = new SolidBrush(Color.Black);

            //Draw receipt
            fg.Clear(Color.LightGray);

            orderNumber = orderNumber + 1;

            fg.DrawRectangle(receiptPen, 250, 30, 225, 25);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 25);

            Thread.Sleep(250); //1

            fg.DrawRectangle(receiptPen, 250, 30, 225, 50);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 50);
            fg.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);

            Thread.Sleep(250); //2

            fg.DrawRectangle(receiptPen, 250, 30, 225, 100);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 100);
            fg.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            fg.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);

            Thread.Sleep(250); //3

            fg.DrawRectangle(receiptPen, 250, 30, 225, 150);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 150);
            fg.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            fg.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            fg.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);

            Thread.Sleep(250); //4

            fg.DrawRectangle(receiptPen, 250, 30, 225, 200);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 200);
            fg.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            fg.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            fg.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            fg.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);

            Thread.Sleep(250); //5

            fg.DrawRectangle(receiptPen, 250, 30, 225, 250);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 250);
            fg.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            fg.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            fg.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            fg.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);
            fg.DrawString("Subtotal =" + subTotal.ToString("$0.00")
                , printFont, printBrush, 275, 260);

            Thread.Sleep(250); //6

            fg.DrawRectangle(receiptPen, 250, 30, 225, 300);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 300);
            fg.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            fg.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            fg.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            fg.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);
            fg.DrawString("Subtotal =" + subTotal.ToString("$0.00")
                , printFont, printBrush, 275, 260);
            fg.DrawString("Tax =" + totalTax.ToString("$0.00")
                , printFont, printBrush, 275, 310);

            Thread.Sleep(250); //7

            fg.DrawRectangle(receiptPen, 250, 30, 225, 350);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 350);
            fg.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            fg.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            fg.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            fg.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);
            fg.DrawString("Subtotal =" + subTotal.ToString("$0.00")
                , printFont, printBrush, 275, 260);
            fg.DrawString("Tax =" + totalTax.ToString("$0.00")
                , printFont, printBrush, 275, 310);
            fg.DrawString("Total =" + total.ToString("$0.00")
                , printFont, printBrush, 275, 360);

            Thread.Sleep(250); //8

            fg.DrawRectangle(receiptPen, 250, 30, 225, 400);
            fg.FillRectangle(receiptBrush, 250, 30, 225, 400);
            fg.DrawString("Order Number " + orderNumber, printFont, printBrush, 275, 70);
            fg.DrawString("Hamburgers x" + burgers + " @" +
                BURGER_PRICE.ToString("$0.00"), printFont, printBrush, 275, 110);
            fg.DrawString("Fries x" + fries + " @" +
                FRIES_PRICE.ToString("$0.00"), printFont, printBrush, 275, 160);
            fg.DrawString("Drinks x" + drinks + " @" +
                DRINKS_PRICE.ToString("$0.00"), printFont, printBrush, 275, 210);
            fg.DrawString("Subtotal =" + subTotal.ToString("$0.00")
                , printFont, printBrush, 275, 260);
            fg.DrawString("Tax =" + totalTax.ToString("$0.00")
                , printFont, printBrush, 275, 310);
            fg.DrawString("Total =" + total.ToString("$0.00")
                , printFont, printBrush, 275, 360);
            fg.DrawString("Amount Tendered =" + amountTendered.ToString("$0.00") + "\n" +
                "Change Due = " + change.ToString("$0.00"), printFont, printBrush, 275, 400);

            newButton.Visible = true;
            receiptButton.Visible = false;
        }

        //New order
        private void newButton_Click(object sender, EventArgs e)
        {
            burgers = 0;
            fries = 0;
            drinks = 0;
            amountTendered = 0;

            burgerBox.Text = "0";
            friesBox.Text = "0";
            drinkBox.Text = "0";
            tenderedBox.Text = "0";
            totalLabel.Text = "";
            changeLabel.Text = "";

            newButton.Visible = false;
        }
    }
}

