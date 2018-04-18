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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }


        double a = 0;
        double b = 0;
        double c = 0;
        double result;

        bool label = false;

        int equalclicked = 0;

        double memory = 0;

        string sign ="";

        bool newop = false;

        

        private void ClearLast_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

       

        private void Sqrt_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = Math.Sqrt(a);
            textBox1.Text = c.ToString();
        }

        private void Digits_Click(object sender, EventArgs e)
        {
            label = true;

            if(textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if(newop == true)
            {
                textBox1.Text = (sender as Button).Text;
                newop = false;
            }
            else
            textBox1.Text = textBox1.Text + (sender as Button).Text;

            

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
            a = 0;
            b = 0;
            equalclicked = 0;
            label4.Text = "";
            result = 0;
        }

        private void ClearE_Click(object sender, EventArgs e)
        {
            
            textBox1.Text="0";
            
            
        }

        private void ZnakChange_Click(object sender, EventArgs e) // + - znak auystyru
        {
           if(textBox1.Text != "0")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text.Remove(0, 1);
                }
                else textBox1.Text = '-'+textBox1.Text; 
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label = true;
            a = Convert.ToDouble(textBox1.Text);
            sign = (sender as Button).Text;
            textBox1.Clear();
            
        }

        private void First_Click(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {
            newop = true;
            label = false;
            label4.Text="";
            
            equalclicked++;
            if (equalclicked == 1)
            {
                b = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            switch (sign)
            {
                case "+":
                    c = a + b;

                    break;

                case "-":
                    c = a - b;
                    break;

                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                case "%": c = (a * b) / 100;
                    break;
                case "=": c = c + b;
                    break;
            }
            textBox1.Clear();
            equalclicked = 0;
            textBox1.Text = c.ToString();
            label4.Text = c.ToString();
            result = c;
        }

        private void Inverse_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = 1 / a;
            textBox1.Text = c.ToString();
            equalclicked = 0;
        }

        private void PointFloat_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            if (!textBox1.Text.Contains(","))
            textBox1.Text=textBox1.Text + ",";
             
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void MemoryReader_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }

        private void MemorySave_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(textBox1.Text);
        }

        private void MemoryPlus_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDouble(textBox1.Text);
        }

        private void MemoryMinus_Click(object sender, EventArgs e)
        {
            memory = memory - Convert.ToDouble(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (label == true)
                label4.Text = Convert.ToDouble(a) + sign;
                      
        }
    }
}
