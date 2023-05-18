using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Years_Calculator
{
    public partial class Form1 : Form
    {
        int years;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Enabled = false;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            lblResult.Enabled = true;
            lblResult.Text = "This is now visable";
            years = int.Parse(txtAge.Text);
            lblResult.Text = "Your age in dog years is: " +  (years * 7).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResult.Enabled = false;
            lblResult.Text = "";
            years = 0;
            txtAge.Text = string.Empty;
        }
    }
}
