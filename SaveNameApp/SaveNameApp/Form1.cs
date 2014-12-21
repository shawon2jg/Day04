﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList NameList = new ArrayList();
        double count = 0;


        private void saveButton_Click(object sender, EventArgs e)
        {

            if (NameList.Count < 10)
            {
                NameList.Add(nameTextBox.Text);
                if (NameList.Count == 10)
                {
                    foreach (string s in NameList)
                    {
                        showListBox.Items.Add(s);
                    }
                }
            }

            else
            {
                MessageBox.Show("You can not input any more data");
            }

            
            countLabel.Text = Convert.ToString(NameList.Count);
            nameTextBox.Clear();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            foreach (string s in NameList)
            {
                showListBox.Items.Add(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
