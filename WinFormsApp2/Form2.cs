﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 AddRec = new Form1();
            this.Hide();
            AddRec.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 AddRec = new Form3();
            this.Hide();
            AddRec.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
