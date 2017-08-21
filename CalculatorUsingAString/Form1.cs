using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUsingAString
{
    public partial class Form1 : Form
    {
        CalcFromString myCalcFromString = new CalcFromString();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = myCalcFromString.RunCalc(txtInput.Text);
            lbxAnswer.Items.Add(txtInput.Text + " = " + lblAnswer.Text);
        }

    }
}
