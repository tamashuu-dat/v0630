using System;
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
        int [] vx = new int[100];
        int [] vy = new int[100];
        Label[] labels = new Label[100];//スペースの確保

        // 静的=最初に決めておく <=> 動的=実行時に変更可能
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            /*for(int ii=0;ii<3;ii++)
            {
                MessageBox.Show($"{ii}");//for文の確認
            }*/

            for (int i = 0; i < 100; i++)
            {
                vx[i] = rand.Next(-10, 11);
                vy[i] = rand.Next(-10, 11);
                labels[i] = new Label();//実体の準備
                labels[i].AutoSize = true;
                labels[i].Text = "★";
                Controls.Add(labels[i]);

                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);
            }

            /*label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<100;i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];
                if(labels[i].Left<0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if(labels[i].Top<0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (labels[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if(labels[i].Bottom>ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
            }
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;

            for(int i=0;i<100;i++)
            {
                if ((labels[i].Left <= fpos.X)
               && (labels[i].Top <= fpos.Y)
               && (labels[i].Right > fpos.X)
               && (labels[i].Bottom > fpos.Y))
                {
                    labels[i].Visible = false;
                }
            }

            /*if (label1.Left<0)
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
            }*/



            /*if ((label1.Left <= fpos.X)
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
            }*/

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
