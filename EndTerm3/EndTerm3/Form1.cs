using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndTerm3
{
    public partial class Form1 : Form
    {

        List<string> email;
        List<string> password;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            email = new List<string>();
            password = new List<string>();
            if (textBox1.Text.Contains("@"))
            {
                email.Add(textBox1.Text);
                password.Add(textBox2.Text);
            }
            else
            {
                label4.Text = "Wrong";
            }
            
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool ok = false;

           for(int i=0; i<email.Count; i++)
            {
                
                

                    if (textBox3.Text == email[i] && textBox4.Text == password[i])
                    {
                    ok = true;
                        label3.Text = "Authorized";
                    
                    }

                  
                
            }
            if (ok == false)
            {
                label3.Text = "Wrong";
            }
            textBox3.Clear();
            textBox4.Clear();


        }
    }
}
