using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Zad4
{
    public partial class Form1 : Form
    {
        private StringBuilder builder = new StringBuilder();
        private DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            builder.Append(0);
            box1.Text = builder.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            builder.Append(1);
            box1.Text = builder.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            builder.Append(2);
            box1.Text = builder.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            builder.Append(3);
            box1.Text = builder.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            builder.Append(6);
            box1.Text = builder.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            builder.Append(5);
            box1.Text = builder.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            builder.Append(4);
            box1.Text = builder.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            builder.Append(7);
            box1.Text = builder.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            builder.Append(8);
            box1.Text = builder.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            builder.Append(9);
            box1.Text = builder.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            builder.Append("/");
            box1.Text = builder.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            builder.Append("*");
            box1.Text = builder.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            builder.Append("-");
            box1.Text = builder.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            builder.Append("+");
            box1.Text = builder.ToString();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            var result = table.Compute(builder.ToString(), string.Empty);
            box1.Text = result.ToString();
            builder.Clear();
            builder.Append(box1.Text.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            builder.Clear();
            box1.Text = string.Empty;
        }
    }
}
