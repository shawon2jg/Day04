using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable bookInfo = new Hashtable();
        private void addButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbnToAddTextBox.Text) == true)
            {
                MessageBox.Show("Data Already Added");
            }
            else
            {
                bookInfo.Add(isbnToAddTextBox.Text, bookDetailsToAddTextBox.Text);
                MessageBox.Show("Successfully Data Saved");
                isbnToAddTextBox.Clear();
                bookDetailsToAddTextBox.Clear();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbnToSearchTextBox.Text) == true)
            {
                bookDetailsToSearchTextBox.Text = (string)bookInfo[isbnToSearchTextBox.Text];
            }
            else
            {
                MessageBox.Show("Data Are Not Found");
                
            }
        }
    }
}
