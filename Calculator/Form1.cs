using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
     
    public partial class Form1 : Form
    {
        public string operation; 
        public double Firstnum=0;
        public double Firstmulti = 1;
        public double sum = 0;
        bool isClicked = false;
        bool isFirst = false;
        bool isFirst2 = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text =  txtDisplay.Text +btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            isFirst = false;
            isFirst2 = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "plus";
            isClicked = false;

             Firstnum =Firstnum+ Convert.ToDouble( txtDisplay.Text);
             Preview.Text = Preview.Text+Firstnum + btnPlus.Text;
             isFirst = false;
            
            txtDisplay.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "plus":
                    {
                        if (txtDisplay.Text == "")
                        {
                            sum = Firstnum + Firstnum;

                        }
                        else
                        {
                            double Secondnum = Convert.ToDouble(txtDisplay.Text);
                            sum = Firstnum + Secondnum;
                        }
                        Firstnum = 0;
                        break;
                    }
                case "minus":
                    {
                        if (txtDisplay.Text == "")
                        {
                            sum = Firstnum - Firstnum;

                        }
                        else
                        {
                            double Secondnum = Convert.ToDouble(txtDisplay.Text);
                            sum = Firstnum - Secondnum;
                        }
                        Firstnum = 0;


                        break;
                    }
                case "multiply":
                    {

                        if (txtDisplay.Text == "")
                        {
                            sum = Firstmulti * Firstmulti;

                        }
                        else
                        {
                            double Secondnum = Convert.ToDouble(txtDisplay.Text);
                            sum = Firstmulti * Secondnum;
                        }
                        Firstmulti = 1;


                        break;
                    }
                case "divide":
                    {

                           if (txtDisplay.Text == "")
                        {
                            sum = Firstmulti / Firstmulti;

                        }
                        else
                        {
                            double Secondnum = Convert.ToDouble(txtDisplay.Text);
                            sum = Firstmulti / Secondnum;
                        }
                           Firstmulti = 1;

                        break;
                    }

            }
           
            
            txtDisplay.Text = sum.ToString();
            
            isClicked = false;

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (isClicked == true)
            {
                MessageBox.Show("This symbol cannot be used twice");
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
                isClicked = true;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Preview_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "minus";
            isClicked = false;
            if (isFirst2 == false)
            {
                Firstnum =  Convert.ToDouble(txtDisplay.Text)-Firstnum ;
                isFirst2 = true;
            
            
            }
            else
                Firstnum = Firstnum - Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "multiply";
            isClicked = false;

            Firstmulti = Firstmulti * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "divide";
            isClicked = false;
            if (isFirst == false)
            {
                Firstmulti = Convert.ToDouble(txtDisplay.Text) / Firstmulti;
                isFirst = true;
            }
            else
                Firstmulti = Firstmulti / Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }
    }
}
