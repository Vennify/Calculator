using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double Result = 0;
        String Operation = "";
        bool isOperation = false;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button_1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if ((TextBoxResult.Text == "0") || (isOperation))
                TextBoxResult.Clear();
           

             isOperation = false;
             Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!TextBoxResult.Text.Contains("."))
                    TextBoxResult.Text = TextBoxResult.Text + button.Text;


            }else

            TextBoxResult.Text = TextBoxResult.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Result != 0)
            {
                button_eq.PerformClick();
                Operation = button.Text;
                LabelCurrentOperation.Text = Result + " " + Operation;
                isOperation = true;
            }
            else
            {


                Operation = button.Text;
                Result = Double.Parse(TextBoxResult.Text);
                LabelCurrentOperation.Text = Result + " " + Operation;
                isOperation = true;
            }
        }

        private void button_Clear_entry_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = "0";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = "0";
            Result = 0;
        
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            switch(Operation)
            {
                case "+":
                    TextBoxResult.Text = (Result + Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "-":
                    TextBoxResult.Text = (Result - Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "×":
                    TextBoxResult.Text = (Result * Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "÷":
                    TextBoxResult.Text = (Result / Double.Parse(TextBoxResult.Text)).ToString();
                    break;
                default:
                    break;
           
            }
            Result = Double.Parse(TextBoxResult.Text);
            LabelCurrentOperation.Text = "";
        }

        private void button_del_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
