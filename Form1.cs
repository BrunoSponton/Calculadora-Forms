using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Prueba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresul.Text = "";
            txtbA.Text = "0";
            txtbB.Text = "0";

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtbA.Text);
            double b = Convert.ToDouble(txtbB.Text);
            double r = a + b;

            lblresul.Text = r.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtbA.Text);
            double b = Convert.ToDouble(txtbB.Text);
            double r = a - b;

            lblresul.Text = r.ToString();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtbA.Text);
            double b = Convert.ToDouble(txtbB.Text);
            double r = a * b;

            lblresul.Text = r.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtbA.Text);
            double b = Convert.ToDouble(txtbB.Text);
            double r = a / b;

            lblresul.Text = r.ToString();
        }
    }
}
