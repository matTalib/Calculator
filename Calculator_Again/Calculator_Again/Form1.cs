using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Again
{
    public partial class Form1 : Form
    {
        string input = string.Empty;        //current input number
        string operand1 = string.Empty;     //first operand
        string operand2 = string.Empty;     //second operand
        char operation;                     //operator (+,-,*,/)
        double result = 0.0;                //results
        public Form1()
        {
            InitializeComponent();
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textdisplay.Text = input;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = ( Button)sender;
            operand1 = input;
            operation = Convert.ToChar(button.Text);
            input = string.Empty;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1;
            double num2;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+':
                    result = num1 + num2; 
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result =num2 !=0 ? num1/ num2 : double.NaN;
                    break;
            }
            textdisplay.Text = result.ToString();
            input = result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            operand1= string.Empty;
            operand2= string.Empty;
            textdisplay.Text = string.Empty;
        }
    }
}
