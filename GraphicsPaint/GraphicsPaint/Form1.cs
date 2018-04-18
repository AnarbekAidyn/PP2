using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen pen;


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pen = new Pen(Color.Blue, 3);
            e.Graphics.DrawLine(pen, 50, 20, 20, 120);
            e.Graphics.DrawLine(pen, 50, 20, 80, 120);
            e.Graphics.DrawLine(pen, 23, 80, 80, 80);

            e.Graphics.DrawLine(pen, 100, 35, 100, 120);
            e.Graphics.DrawLine(pen, 160, 35, 160, 120);
            e.Graphics.DrawLine(pen, 100, 120, 160, 35);
            e.Graphics.DrawLine(pen, 125, 20, 135, 20);

               
        }
    }
}
