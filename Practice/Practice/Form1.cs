using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        Button[,] buttons;
        
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[6, 6];
            
            for(int i=0; i<6; i++)
            {
                for(int j=0; j<6; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].BackColor = Color.Green;
                    buttons[i, j].Height = 40;
                    buttons[i, j].Width = 40;
                    buttons[i, j].Location = new Point(i*40+10, j*40+10);
                    Controls.Add(buttons[i, j]);
                    buttons[i, j].Click += button1_Click;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int hor=0;
            int ver=0;
            for(int i = 0; i<6; i++)
            {
                for(int j=0; j<6; j++)
                {
                    if (buttons[i, j] == btn)
                    {
                        hor = i;
                        ver = j;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
                buttons[i, ver].BackColor = Color.Cyan;

            for (int j = 0; j < 6; j++)
                buttons[hor, j].BackColor = Color.Cyan;

        }
    }
}