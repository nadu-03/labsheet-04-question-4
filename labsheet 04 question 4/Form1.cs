
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question__4
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result_value = 0;
        bool is_Operation_Performed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || is_Operation_Performed)
            {
                Result.Clear(); // clear initial value
            }
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!Result.Text.Contains("."))
                {
                    Result.Text = Result.Text + btn.Text;
                }
            }
            else
            {
                Result.Text = Result.Text + btn.Text;
            }

            is_Operation_Performed = false;
        }

        private void operation_Performed(object sender, EventArgs e)
        {
            try
            {
                if (result_value != 0)
                {
                    button9.PerformClick();
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(Result.Text);
                    lb_Result.Text = result_value + operation;
                    is_Operation_Performed = true;
                }
                else
                {
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(Result.Text);
                    lb_Result.Text = result_value + operation;
                    is_Operation_Performed = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid number", "Error");
                lb_Result.Text = "";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Result.Text = "0"; //CE Button
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Result.Text = "0"; // Clear button
            lb_Result.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        Result.Text = (result_value + double.Parse(Result.Text)).ToString();
                        break;
                    case "-":
                        Result.Text = (result_value - double.Parse(Result.Text)).ToString();
                        break;
                    case "*":
                        Result.Text = (result_value * double.Parse(Result.Text)).ToString();
                        break;
                    case "/":
                        if (double.Parse(Result.Text) == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        Result.Text = (result_value / double.Parse(Result.Text)).ToString();
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid number", "Error");
            }
            catch (DivideByZeroException)
            {

                MessageBox.Show("Cannot Divide by Zero", "Error");

            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
