using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculator
{
    public partial class WinFormCal : Form
    {
        public WinFormCal()
        {
            InitializeComponent();
        }

        private void WinFormCal_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int num1, num2;
            string ans = "";
            num1 = Int32.Parse(opNum1.Text);
            num2 = Int32.Parse(opNum2.Text);
            foreach (var rb in OperatorChoises.Controls)
            {
                if (rb is RadioButton)
                {
                    RadioButton op = rb as RadioButton;
                    if (op.Checked)
                    {
                        ans = CalculateAnswer(num1, num2, op.Name);
                        break;
                    }
                }
            }
            Ans.Text = ans;
        }

        private string CalculateAnswer(int num1, int num2, string op)
        {
            switch (op)
            {
                case "add":
                    return $"{num1 + num2}";
                case "sub":
                    return $"{num1 - num2}";
                case "mul":
                    return $"{num1 * num2}";
                case "div":
                    if(num2 != 0)
                    {
                        return $"{num1 / num2}";
                    }
                    return "Invalid Input!";
                default:
                    return "Invalid Input!";
            }
        }
    }
}
