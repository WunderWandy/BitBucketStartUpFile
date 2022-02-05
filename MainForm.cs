/* InClass1WandaEby
Windows Form Calculator
Revision: 0
Wanda Eby, 2021.01.28: Created
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1WandaEbyCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Declare variables and intialize
        private double x = 0.0;
        private string pendingOperation = "";
        private bool isNewNumber = true;

        
        // Method to handle the digit and decimal click
        private void DigitOrDecimalClick(object sender, EventArgs e)
        {
            //checking if the number is a new one
            if (isNewNumber)
            {
                txtCurrentValue.Text = "";
                lblDisplayEquation.Text = "";
                isNewNumber = false;
            }
            //Cast to button to append text
            Button currentBtn = (Button)sender;
            txtCurrentValue.Text += currentBtn.Text;        
        }

        // Store the value in textbox in x, clear textbox and store the operator 
        // in pendingOperation using cast.
        private void ArithmeticOperator(object sender, EventArgs e)
        {
            x = double.Parse(txtCurrentValue.Text);
            txtCurrentValue.Text = "";
            Button currentBtn = (Button)sender;
            pendingOperation = currentBtn.Text;
        }

        // When C button is clicked it will clear everything, including info stored in variables
        private void ClearClick(object sender, EventArgs e)
        {
            txtCurrentValue.Text = "";
            lblDisplayEquation.Text = "";
            x = 0;
            pendingOperation = "";
            isNewNumber = true;
        }
        // When CE button is clicked it will only clear the textbox.
        private void ClearEntryClick(object sender, EventArgs e)
        {
            txtCurrentValue.Text = "";
        }

        // When equals is clicked the operator stored in pendingOperation is used to perform the 
        // calculation and then the equation is concatenated and moved to the label display box
        // followed by clearing the variables.
        private void EqualsClick(object sender, EventArgs e)
        {
            lblDisplayEquation.Text = x + " " + pendingOperation + " " + txtCurrentValue.Text;

            switch (pendingOperation)
            {
                case "+":
                    txtCurrentValue.Text = (x + double.Parse(txtCurrentValue.Text)).ToString();
                break;
                case "-":
                    txtCurrentValue.Text = (x - double.Parse(txtCurrentValue.Text)).ToString();
                    break;
                case "*":
                    txtCurrentValue.Text = (x * double.Parse(txtCurrentValue.Text)).ToString();
                    break;
                case "/":
                    txtCurrentValue.Text = (x / double.Parse(txtCurrentValue.Text)).ToString();
                    break;
                default:
                    break;
            };
            
            x = 0;
            pendingOperation = "";
            isNewNumber = true;
        }
    }
}
