using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Decimal_Converter
{
    public partial class Form1 : Form
    {
        int oneTwentyEight = 128;
        int sixtyFour = 64;
        int thirtyTwo = 32;
        int sixteen = 16;
        int eight = 8;
        int four = 4;
        int two = 2;
        int one = 1;

        int results = 0;

        public Form1()
        {
            InitializeComponent();

            this.mnuHelpAbout.Click += MnuHelpAbout_Click;

            // Binary to Decimal
            this.btnBinaryConvert.Click += BtnConvert_Click;
            this.btnBinaryClear.Click += BtnClear_Click;

            // Decimal to Binary
            this.btnDecimalConvert.Click += BtnDecimalConvert_Click;
            this.btnClearDecimal.Click += BtnClearDecimal_Click;
        }

        private void BtnClearDecimal_Click(object sender, EventArgs e)
        {
            this.txtDecimal.Text = "";
            this.lbl128.Text = "";
            this.lbl64.Text = "";
            this.lbl32.Text = "";
            this.lbl16.Text = "";
            this.lbl8.Text = "";
            this.lbl4.Text = "";
            this.lbl2.Text = "";
            this.lbl1.Text = "";
        }

        private void BtnDecimalConvert_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Binary to Decimal
        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.num128.Value = 0;
            this.num64.Value = 0;
            this.num32.Value = 0;
            this.num16.Value = 0;
            this.num8.Value = 0;
            this.num4.Value = 0;
            this.num2.Value = 0;
            this.num1.Value = 0;
            this.lblDecimal.Text = "";
            results = 0;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if(this.num128.Value == 1)
            {
                results += oneTwentyEight;
            }

            if (this.num64.Value == 1)
            {
                results += sixtyFour;
            }

            if (this.num32.Value == 1)
            {
                results += thirtyTwo;
            }

            if (this.num16.Value == 1)
            {
                results += sixteen;
            }

            if (this.num8.Value == 1)
            {
                results += eight;
            }

            if (this.num4.Value == 1)
            {
                results += four;
            }

            if (this.num2.Value == 1)
            {
                results += two;
            }

            if (this.num1.Value == 1)
            {
                results += one;
            }


            this.lblDecimal.Text = results.ToString();
        }

        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();

            form.ShowDialog();
        }
    }
}
