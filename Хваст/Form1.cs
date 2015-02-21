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
        public Graphics gr;
        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Red);
            Point point1 = new Point(rnd.Next(1000), rnd.Next(1000));
            Point point2 = new Point(rnd.Next(1000), rnd.Next(1000));
            gr.DrawLine(p, point1, point2);
        }
    }
}
