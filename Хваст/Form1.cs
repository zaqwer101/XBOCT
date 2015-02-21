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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Red);
            Point point1 = new Point(1, 1);
            Point point2 = new Point(100, 100);
            gr.DrawLine(p, point1, point2);
        }
    }
}
