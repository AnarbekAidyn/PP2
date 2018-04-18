using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        Bitmap bmp;
        Point prev, cur;
        bool clicked;
        enum Tool
        {
            PEN,
            RECTANGLE,
            ELLIPSE
        }

        Tool tool;

        public Form1()
        {
            InitializeComponent();
           
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            clicked = false;
            pen = new Pen(Color.Black, 3);
            tool = Tool.PEN;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tool.PEN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.RECTANGLE;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tool = Tool.ELLIPSE;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if(tool == Tool.PEN && clicked == true)
            {
                g.DrawLine(pen, prev, cur);
                prev = cur;
            }
            pictureBox1.Refresh();
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pen.Color = btn.BackColor;
        }

    }
}
