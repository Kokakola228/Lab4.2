using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, 200, 100, 400, 100);
            g.DrawEllipse(pen, 200, 200, 50, 50);
            g.DrawEllipse(pen, 500, 200, 50, 50);
            g.DrawRectangle(pen, 50, 170, 150, 30);
            g.DrawRectangle(pen, 200, 100, 80, 70);
            g.DrawRectangle(pen, 370, 100, 80, 70);
            g.DrawRectangle(pen, 500, 100, 80, 70);


            pictureBox1.Image = bmp;
           
        }
    }
}
