using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Asteroids
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen pen;
        SolidBrush sb;
        Point[] a;
        SolidBrush asteroid;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            pen = new Pen(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            sb = new SolidBrush(Color.White);
            a = new Point[12];
            asteroid = new SolidBrush(Color.Red);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
                        //Backgrond
            SolidBrush brushrectangle = new SolidBrush(Color.Black);
            Rectangle r1 = new Rectangle(0, 0, Width, Height);
            g.FillRectangle(brushrectangle, r1);

            SolidBrush brush = new SolidBrush(Color.Blue);
            Rectangle r2 = new Rectangle(12, 12, 755, 385);
            g.FillRectangle(brush, r2);

            //Circles
            
            Rectangle c1 = new Rectangle(40, 88 , 25, 25);
            g.FillEllipse(sb, c1);

            Rectangle c2 = new Rectangle(50, Height - 140, 25, 25);
            g.FillEllipse(sb, c2);


            Rectangle c3= new Rectangle(285, 72, 25, 25);
            g.FillEllipse(sb, c3);

            Rectangle c4 = new Rectangle(425, 104, 25, 25);
            g.FillEllipse(sb, c4);

            Rectangle c5 = new Rectangle(295, Height-130, 25, 25);
            g.FillEllipse(sb, c5);

            Rectangle c6 = new Rectangle(Width-130, 240, 25, 25);
            g.FillEllipse(sb, c6);

            Rectangle c7 = new Rectangle(Width-60, Height - 100, 25, 25);
            g.FillEllipse(sb, c7);

            Rectangle c8 = new Rectangle(Width-65, 160, 25, 25);
            g.FillEllipse(sb, c8);

            //Spaceship
            Point[] arr = {
                new Point(300, 150),
                new Point(350, 200),
                new Point(350, 250),
                new Point(300, 300),
                new Point(250,250),
                new Point(250,200)
            };
            SolidBrush Polbrush = new SolidBrush(Color.Yellow);
            e.Graphics.FillPolygon(Polbrush, arr);
            Pen pen = new Pen(Color.Yellow, 5);
            e.Graphics.DrawPolygon(pen, arr);

            //GUN
            Point[] arr2 =
       {
                new Point(300,165),
                new Point(315,180),
                new Point(305,180),
                new Point(305,210),
                new Point(295,210),
                new Point(295,180),
                new Point(285,180)

            };
            SolidBrush Gunbrush = new SolidBrush(Color.Green);
            e.Graphics.FillPolygon(Gunbrush, arr2);
            Pen pen2 = new Pen(Color.Green, 5);
            e.Graphics.DrawPolygon(pen2, arr2);

            //BULLET
            Point[] arr4 =
            {
                new Point(300,100),
                new Point(310,110),
                new Point(325,115),
                new Point(310,120),
                new Point(300,130),
                new Point(290,120),
                new Point(275,115),
                new Point(290,110)
            };
            Pen pen4 = new Pen(Color.Green, 5);
            e.Graphics.DrawPolygon(pen4, arr4);


            Point[] arr3 =
           {
                new Point(150,150),
                new Point(160,155),
                new Point(165,155),
                new Point(155,160),
                new Point(165,165),
                new Point(160,165),
                new Point(150,170),
                new Point(140,165),
                new Point(135,165),
                new Point(145,160),
                new Point(135,155),
                new Point(140,155)
            };
            
            e.Graphics.FillPolygon(asteroid, arr3);
            Pen pen3 = new Pen(Color.Red, 5);
            e.Graphics.DrawPolygon(pen3, arr3);

            Point[] arrr =
           {
                new Point(170,250),
                new Point(180,255),
                new Point(185,255),
                new Point(175,260),
                new Point(185,265),
                new Point(180,265),
                new Point(170,270),
                new Point(160,265),
                new Point(155,265),
                new Point(165,260),
                new Point(155,255),
                new Point(160,255)
            };
            
            e.Graphics.FillPolygon(asteroid, arrr);
            Pen pen8 = new Pen(Color.Red, 5);
            e.Graphics.DrawPolygon(pen8, arrr);


            Point[] array =
        {
               new Point(150+420,150+175),
                new Point(160+420,155+175),
                new Point(165+420,155+175),
                new Point(155+420,160+175),
                new Point(165+420,165+175),
                new Point(160+420,165+175),
                new Point(150+420,170+175),
                new Point(140+420,165+175),
                new Point(135+420,165+175),
                new Point(145+420,160+175),
                new Point(135+420,155+175),
                new Point(140+420,155+175)


            };
            
            e.Graphics.FillPolygon(asteroid, array  );
            Pen pen9 = new Pen(Color.Red, 5);
            e.Graphics.DrawPolygon(pen9, array);


            Point[] ar =
           {
                new Point(150+300,160),
                new Point(160+300,165),
                new Point(165+300,165),
                new Point(155+300,170),
                new Point(165+300,175),
                new Point(160+300,175),
                new Point(150+300,180),
                new Point(140+300,175),
                new Point(135+300,175),
                new Point(145+300,170),
                new Point(135+300,165),
                new Point(140+300,165)
            };

            e.Graphics.FillPolygon(asteroid, ar);
            Pen pen10 = new Pen(Color.Red, 5);
            e.Graphics.DrawPolygon(pen10, ar);

        }
        //public void Draw_Asteroids(int x, int y)
       // {
           // a[0] = new Point(x, y);
            //a[1] = new Point(x, y);
        // }
    }
}
