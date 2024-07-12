using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using org.mariuszgromada.math.mxparser;

namespace CalculatorUsingAString
{
    //https://mathparser.org/  https://dotnetfiddle.net/M6EhcY

    public partial class Form1 : Form
    {
        // CalcFromString myCalcFromString = new CalcFromString();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Button FakeButton = (Button)sender;

            //  lblAnswer.Text = FakeButton.Text;

            //   lblAnswer.Text = myCalcFromString.RunCalc(txtInput.Text);
            //   lbxAnswer.Items.Add(txtInput.Text + " = " + lblAnswer.Text);
            Expression Answer = new Expression(txtInput.Text);

            lbxAnswer.Items.Add(Answer.getExpressionString() + " = " + Answer.calculate());


        }

    }
}

//// Basic calculation
//Expression e1 = new Expression("2+3-(3-4/2)+5!");
//// Using built-in functions
//Expression e2 = new Expression("sin(pi)+cos(pi)");
//// Using fractions
//Expression e3 = new Expression("1_2 + 1_1_2");
//// Using various numeral systems
//Expression e4 = new Expression("h.112f+o.123+b.00101+b7.1234");
//// Using scientific notation
//Expression e5 = new Expression("-1e10+1e-2+2+e+10");
//// calculation
//Console.WriteLine(e1.getExpressionString() + " = " + e1.calculate());
//Console.WriteLine(e2.getExpressionString() + " = " + e2.calculate());
//Console.WriteLine(e3.getExpressionString() + " = " + e3.calculate());
//Console.WriteLine(e4.getExpressionString() + " = " + e4.calculate());
//Console.WriteLine(e5.getExpressionString() + " = " + e5.calculate());
