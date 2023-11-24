using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }
        float num1, num2;

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtBox1.Text);
            num2 = float.Parse(txtBox2.Text);

            if (cbOperations.Text == "+")
            {
               float total = BasicComputation.Addition(num1,num2);
               result.Text = total.ToString();
            }
            else if (cbOperations.Text == "-")
            {
                float total = BasicComputation.Subtraction(num1,num2);
                result.Text = total.ToString();
            }
            else if (cbOperations.Text == "*")
            {
                float total = BasicComputation.Multiplication(num1, num2);
                result.Text = total.ToString();
            }
            else if (cbOperations.Text == "/")
            {
                float total = BasicComputation.Division(num1,num2);
                result.Text = total.ToString();
            }
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cbOperations.Items.Add("+");
            cbOperations.Items.Add("-");
            cbOperations.Items.Add("*");
            cbOperations.Items.Add("/");
        }


    }
}
