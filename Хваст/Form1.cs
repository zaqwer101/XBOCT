using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Хваст
{
    public partial class Form1 : Form
    {
        public static int cl_r = 0, cl_g = 0, cl_b = 0;
        public static bool f_red = true, f_green = false, f_blue = false;
        public static Int64 count = 0;
        public static float width = 40;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            
        }
        public Point point1;
        private void Form1_Load(object sender, EventArgs e)
        {
            point1 = new Point(Module.rnd.Next(500), Module.rnd.Next(500));
            Module.bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Module.g = Graphics.FromImage(Module.bmp);
            //gr = pictureBox1.CreateGraphics();
            pictureBox1.Image = Module.bmp;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            cl_r = Module.rnd.Next(255);
            cl_g = Module.rnd.Next(255);
            cl_b = Module.rnd.Next(255);
            Color color = Color.FromArgb(cl_r, cl_g, cl_b);
            Pen p = new Pen(color, width);
            Point point2 = new Point(Module.rnd.Next(600), Module.rnd.Next(600));
            Module.g.DrawLine(p, point1, point2);
            point1 = point2;
            Module.g.FillEllipse(Brushes.Yellow,point2.X - 20,point2.Y - 20,width,width);
            pictureBox1.Image = Module.bmp;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (pictureBox1.Image as Bitmap).Save("c:/blabla.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsInPic)
            {
                label1.BackColor = (pictureBox1.Image as Bitmap).GetPixel(e.X, e.Y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static bool IsInPic;
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            IsInPic = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            IsInPic = false;
        }
    }
}
