﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Opdracht_1 {
    public partial class Form1 : Form {

        List<string> klasgenoten = new List<string>();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {

        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            string name = naam.Text;
            //string
            MessageBox.Show(name);
        }
    }
}
