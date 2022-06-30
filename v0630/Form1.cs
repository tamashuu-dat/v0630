﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        int [] vx = new int[3];
        int [] vy = new int[3];
        
        // 静的=最初に決めておく <=> 動的=実行時に変更可能
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            vx[0] = rand.Next(-10, 11);
            vy[0] = rand.Next(-10, 11);
            vx[1] = rand.Next(-10, 11);
            vy[1] = rand.Next(-10, 11);
            vx[2] = rand.Next(-10, 11);
            vy[2] = rand.Next(-10, 11);

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx[0];
            label1.Top += vy[0];

            label3.Left += vx[1];
            label3.Top += vy[1];

            label4.Left += vx[2];
            label4.Top += vy[2];

            if (label1.Left<0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            if(label1.Top<0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            if(label1.Right>ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if(label1.Bottom>ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }

            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;

            if ((label1.Left <= fpos.X)
                && (label1.Top <= fpos.Y)
                && (label1.Right > fpos.X)
                && (label1.Bottom > fpos.Y))
            {
                timer1.Enabled = false;
            }

            if (label3.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            if (label3.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }

            if ((label3.Left <= fpos.X)
                && (label3.Top <= fpos.Y)
                && (label3.Right > fpos.X)
                && (label3.Bottom > fpos.Y))
            {
                timer1.Enabled = false;
            }

            if (label4.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label4.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }

            if ((label4.Left <= fpos.X)
                && (label4.Top <= fpos.Y)
                && (label4.Right > fpos.X)
                && (label4.Bottom > fpos.Y))
            {
                timer1.Enabled = false;
            }

            /*if((  label1.Left<=label2.Right)
                &&(label1.Top<=label2.Bottom)
                &&(label1.Right>label2.Left)
                &&(label1.Bottom>label2.Top))
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over");
            }*/
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
