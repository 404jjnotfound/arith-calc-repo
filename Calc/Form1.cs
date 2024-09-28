using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e) {}

        public decimal result;
        public decimal operandOne;
        public decimal operandTwo;
        public string arithmeticOperator;

        public Form1()
        {
            InitializeComponent();
        }

        #region
        private void btnOne_Click(object sender, EventArgs e) {
            rTxtBoxDisplay.AppendText(btnOne.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnTwo.Text);
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnSix.Text);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnNine.Text);
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.AppendText(btnZero.Text);
        }
        #endregion

        private decimal OperandOne(string displayedNumber) { return decimal.Parse(displayedNumber); }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operandOne = OperandOne(rTxtBoxDisplay.Text); // store the number from the field as first operand
            arithmeticOperator = "+";
            rTxtBoxDisplay.Text = string.Empty; // clear the field
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operandOne = OperandOne(rTxtBoxDisplay.Text); // store the number from the field as first operand
            arithmeticOperator = "-";
            rTxtBoxDisplay.Text = string.Empty; // clear the field
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operandOne = OperandOne(rTxtBoxDisplay.Text); // store the number from the field as first operand
            arithmeticOperator = "x";
            rTxtBoxDisplay.Text = string.Empty; // clear the field
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operandOne = OperandOne(rTxtBoxDisplay.Text); // store the number from the field as first operand
            arithmeticOperator = "/";
            rTxtBoxDisplay.Text = string.Empty; // clear the field
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                // Compute the contents from rich textbox
                operandTwo = decimal.Parse(rTxtBoxDisplay.Text); // store the number from the field as second operand
                rTxtBoxDisplay.Text = string.Empty; // clear the field

                // Perform the operation based on the given operator
                switch (arithmeticOperator)
                {
                    case "+":
                        result = operandOne + operandTwo; 
                        break;
                    case "-":
                        result = operandOne - operandTwo;
                        break;
                    case "x":
                        result = operandOne * operandTwo; 
                        break;
                    case "/":
                        result = operandOne / operandTwo;
                        break;
                }

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You can't divide a dividend by zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()} says '{ex.Message}'", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Display the result
            rTxtBoxDisplay.AppendText(Math.Round(result, 4).ToString()); // round off up to 4 decimal places
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rTxtBoxDisplay.Text = string.Empty; // clear the field
            
            // Reset both operands and total back to zero
            operandOne = 0; 
            operandTwo = 0;
            result = 0;
        }
    }
}
