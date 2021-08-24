﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }
        double termenFibonacci(int n)
        {
            int i;
            double f0, f1, fn = 0;
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                f0 = 0;
                f1 = 1;

                i = 2;
                while (i <= n)
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                    i++;
                }
                return fn;
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rez_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = Convert.ToInt16(camp_n.Text);
                if (n > 500)
                    MessageBox.Show("Too big, value less than 500!", "Careful!");
                else if (n < 0)
                    MessageBox.Show("Number needs to be positive!", "Careful!");
                else
                {
                    rez.Text = "";//se sterg calculele anterioare
                    for (int i = 0; i <= n; i++)
                        rez.Text += "Term = " + i + " Value = " + termenFibonacci(i) + "\r\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Natural number needed!", "Careful!");
            }

        }

        private void camp_n_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Return)
            {
                this.button1_Click(this.button1, null);
            }
        }
    }
}
