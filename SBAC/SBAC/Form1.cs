using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBAC
{
    public partial class FormCalculator : Form
    {
        String Expression;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "1";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "1";
            }
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "2";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "2";
            }
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "3";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "3";
            }
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "4";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "4";
            }
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "5";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "5";
            }
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "6";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "6";
            }
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "7";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "7";
            }
        }


        private void Button_8_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "8";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "8";
            }
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != null && ResultTextbox.Text == "0")
            {
                ResultTextbox.Text = "9";
                Button_0.Enabled = true;
            }
            else
            {
                Button_0.Enabled = true;
                Plus_Button.Enabled = true;
                Subtraction_Button.Enabled = true;
                Multiplication_Button.Enabled = true;
                Division_Button.Enabled = true;
                ResultTextbox.Text += "9";
            }
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text == "")
            {
                ResultTextbox.Text = "0";
                Button_0.Enabled = false;
            }
            else
            {
                Plus_Button.Enabled = true;
                ResultTextbox.Text += "0";
            }
        }

        private void Button_Decimal_Click(object sender, EventArgs e)
        {
            if(ResultTextbox.Text == "0" || ResultTextbox.Text != null)
            {
                ResultTextbox.Text += ".";
                Button_Decimal.Enabled = false;
            }

        }
        private void Plus_Button_Click(object sender, EventArgs e)
        {
            if(ResultTextbox.Text != "")
            {
                ResultTextbox.Text += " + ";
                Plus_Button.Enabled = false;
                Subtraction_Button.Enabled = false;
                Multiplication_Button.Enabled = false;
                Division_Button.Enabled = false;
                Button_Decimal.Enabled = true;
            }

        }

        private void Subtraction_Button_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != "")
            {
                ResultTextbox.Text += " - ";
                Plus_Button.Enabled = false;
                Subtraction_Button.Enabled = false;
                Multiplication_Button.Enabled = false;
                Division_Button.Enabled = false;
                Button_Decimal.Enabled = true;
            }
        }

        private void Multiplication_Button_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != "")
            {
                ResultTextbox.Text += " * ";
                Plus_Button.Enabled = false;
                Subtraction_Button.Enabled = false;
                Multiplication_Button.Enabled = false;
                Division_Button.Enabled = false;
                Button_Decimal.Enabled = true;
            }
        }


        private void Division_Button_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text != "")
            {
                ResultTextbox.Text += " / ";
                Plus_Button.Enabled = false;
                Subtraction_Button.Enabled = false;
                Multiplication_Button.Enabled = false;
                Division_Button.Enabled = false;
                Button_Decimal.Enabled = true;
            }

        }


        private void Equal_Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ResultTextbox.Text);
            Expression = ResultTextbox.Text;
            String Result = Convert.ToString(InfixEvaluation.evaluate(Expression));
            ResultTextbox.Text = Result;
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            ResultTextbox.Text = "";
        }

        
    }
}
