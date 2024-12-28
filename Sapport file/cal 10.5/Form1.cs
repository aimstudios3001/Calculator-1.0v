using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal_10._5
{
    public partial class Form1 : Form
    {
        double num1, num2,T;
        string total, opsion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            opsion = "/";
            num1 = double.Parse(TxtDis.Text);
            TxtDis.Clear();
        }

        private void TxtDis_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNum1_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtClear_Click(object sender, EventArgs e)
        {
            TxtDis.Clear();
        }

        private void TxtNum2_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNum3_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNum4_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNum5_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNum6_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNum7_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNum8_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtNum9_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNum0_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtMinas_Click(object sender, EventArgs e)
        {
            opsion = "-";
            num1 = double.Parse(TxtDis.Text);
            TxtDis.Clear();
        }

        private void But1_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "1";
        }

        private void But2_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "2";
        }

        private void But3_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "3";
        }

        private void But4_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "4";
        }

        private void But5_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "5";
        }

        private void But6_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "6";
        }

        private void But7_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "7";
        }

        private void But8_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "8";
        }

        private void But9_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "9";
        }

        private void TxtMulty_Click(object sender, EventArgs e)
        {
            opsion = "x";
            num1 = double.Parse(TxtDis.Text);
            TxtDis.Clear();
        }

        private void But0_Click(object sender, EventArgs e)
        {
            TxtDis.Text = TxtDis.Text + "0";
        }

        private void TxtEkual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(TxtDis.Text);

            if (opsion == ("+")) 
            {
                T = num1 + num2;
            }
            if (opsion == ("-"))
            {
                T = num1 - num2;
            }
            if (opsion == ("x"))
            {
                T = num1 * num2;
            }
            if (opsion == ("/"))
            {
                T = num1 / num2;
            }

            TxtDis.Text = T + "";
        }

        private void TxtSum_Click(object sender, EventArgs e)
        {
            opsion = "+";
            num1 = double.Parse(TxtDis.Text);
            TxtDis.Clear();

        }
    }
}
