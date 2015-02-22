﻿using System;
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
        public static Graphics g;
        public static Bitmap bmp;
        public static Random rnd = new Random();
        public static int cl_r = 0, cl_g = 0, cl_b = 0, score = -1;
        public static bool CanDClick = true;
        public static Int64 count = 0;
        public static float width = 40, _width = width;


        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }
        public Point point1;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            //gr = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (win & !lose & game)
            {

                score++;
                label3.Text = "ВАШ СЧЕТ: " + Convert.ToString(score);
                win = false;
                game = true;
                g.Clear(Color.White);
                pictureBox1.BackColor = Color.White;
                cl_r = rnd.Next(255);
                cl_g = rnd.Next(255);
                cl_b = rnd.Next(255);
                Color color = Color.FromArgb(cl_r, cl_g, cl_b);
                g.FillEllipse(Brushes.Red, point1.X - 20, point1.Y - 20, _width, _width);
                Pen p = new Pen(color, width);
                Point point2 = new Point((rnd.Next(600)), (rnd.Next(600)));
                g.DrawLine(p, point1, point2);
                point1 = point2;
                g.FillEllipse(Brushes.Yellow, point2.X - 20, point2.Y - 20, _width, _width);
                pictureBox1.Image = bmp;
                if (width >= 6)
                    width-=3;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            InScreen = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        public static bool game = true, InScreen = true, win = true, lose = false;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (InScreen)
                {
                    Point point1 = new Point(Cursor.Position.X - 10, Cursor.Position.Y - 12 );
                    Color color1;
                    Point r = this.PointToClient(point1);
                    color1 = bmp.GetPixel(r.X, r.Y);
                    if(color1.Name == "ffffff00" & game)
                    {
                        win = true;
                        label2.Text = "ИДЕТ ИГРА";
                    }
                    if (color1.Name == "ffffffff")
                    {
                        win = false;
                        game = false;
                        label2.Text = "ВЫ ПРОИГРАЛИ";
                        MessageBox.Show("Вы проиграли! Ваш счёт: " + Convert.ToString(score));
                    }
                }
            }
            catch(System.ArgumentOutOfRangeException)
            {
                InScreen = false;
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CanDClick)
            {
                point1 = new Point(e.X, e.Y);
                timer1.Start();
                CanDClick = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Для начала игры, сделайте двойной щелчок примерно в центре игрового поля. Вы должны провести указатель мыши от красной точки до желтой, не выходя за границы линии, иначе игра будет закончена. За каждое достижение желтой точки вам начисляется очко. По мере прохождения толщина линии будет уменьшатся.");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

/* 
            game = true;
            Module.g.Clear(Color.White);
            pictureBox1.BackColor = Color.White;
            cl_r = Module.rnd.Next(255);
            cl_g = Module.rnd.Next(255);
            cl_b = Module.rnd.Next(255);
            Color color = Color.FromArgb(cl_r, cl_g, cl_b);
            Module.g.FillEllipse(Brushes.Red, point1.X - 20, point1.Y - 20, width, width);
            Pen p = new Pen(color, width);
            Point point2 = new Point((Module.rnd.Next(600)), (Module.rnd.Next(600)));
            Module.g.DrawLine(p, point1, point2);
            point1 = point2;
            Module.g.FillEllipse(Brushes.Yellow, point2.X - 20, point2.Y - 20, width, width);
            pictureBox1.Image = Module.bmp;
            if (width >= 6)
                width--;

  
  
  
  
  
 
                Color color1;
                Point r = this.PointToClient(Cursor.Position);
                color1 = Module.bmp.GetPixel(r.X, r.Y);
 */