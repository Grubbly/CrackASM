/*
	crackASMGUI.cs
	Tristan Van Cise
	CS 301 Assembly Language Programming
	09/25/2017
    Button event handling
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
using crackASMGUI;

namespace crackASMGUI
{
    public partial class crackASMGUI : Form
    {
       int inputA;
       int inputB;

        public crackASMGUI()
        {
            InitializeComponent();
        }

        private void clearAllText()
        {
            txtDisplay.Clear();
            txtA.Clear();
            txtB.Clear();
        }


        //getInputs
        //  retrieves input from text boxes, defaults bad values to 
        //  zero, operations work only for integers that do not overflow
        private void getInputs()
        {
            try
            {
                inputA = Convert.ToInt32(txtA.Text);
            }
            catch
            {
                inputA = 0;
            }

            try
            {
                inputB = Convert.ToInt32(txtB.Text);
            }
            catch
            {
                inputB = 0;
            }
        }

        //Addition
        //  uses standard addition opcode from inline assembly in dll
        //  on button press
        private void btnAddition_Click(object sender, EventArgs e)
        {
            getInputs();         
            clearAllText();

            //preform operation and print to text box
            txtDisplay.AppendText( Convert.ToString( crackASMBackend.Addition(inputA, inputB) ) );
            
        }

        public void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Subtraction
        //  uses standard subtraction opcode from inline assembly in dll
        //  on button press
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            getInputs();
            clearAllText();

            txtDisplay.AppendText(Convert.ToString(crackASMBackend.Subtraction(inputA, inputB)));
        }

        //Multiplication
        //  uses standard multiplication opcode from inline assembly in dll
        //  on button press
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            getInputs();
            clearAllText();

            txtDisplay.AppendText(Convert.ToString(crackASMBackend.Multiplication(inputA, inputB)));
        }

        //Division (integer)
        //  denominator is subtracted from numerator, with every subtraction operation, the quotient
        //  is added to by one. Division by zero is handled by printing "UNDEFINED" to output text box.
        private void btnDivision_Click(object sender, EventArgs e)
        {
            getInputs();
            clearAllText();

            if (inputB == 0)
                txtDisplay.AppendText("UNDEFINED");            
            else            
                txtDisplay.AppendText(Convert.ToString(crackASMBackend.Division(inputA, inputB)));           
        }
    }
}
