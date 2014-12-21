using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string customerName;
        private double numberOfTickets;
        private double totalPrice;

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            customerName = customerNameTextBox.Text;
            numberOfTickets = Convert.ToDouble(numberOfTicketsTextBox.Text);
            totalPrice = 10*numberOfTickets;
            MessageBox.Show(customerName + " , Pay  the ticket bill "+ totalPrice + ".");

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name of customer: " + customerName + "\nNumber Of Tickets: " + numberOfTickets +
                            "\nTotal price is: " + totalPrice);
        }
    }
}
