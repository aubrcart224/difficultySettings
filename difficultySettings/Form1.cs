﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace difficultySettings
{
    public partial class Form1 : Form
    { //global variables 
        string user; 

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            user = heroName.Text;
            outputlable.Text = $"Welcome {user}. A true brave hero! Go forth and conquer the easy path!";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
             user = heroName.Text;
            outputlable.Text = $"Welcome {user}. A true brave hero! Go forth and conquer the medium path!";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            user = heroName.Text;
            outputlable.Text = $"Welcome {user}. A true brave hero! Go forth and conquer the hard path!";
        }

        private void beginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
