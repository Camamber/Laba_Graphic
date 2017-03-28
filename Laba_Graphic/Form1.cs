using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_Graphic
{
    public partial class Form1 : Form
    {
        Graphic graphic;
        Graphics g;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            graphic = new Graphic(g, bmp.Size,new Point(0,0));
            Painter.Start();
        }

        private void Painter_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            graphic.Draw();
            pictureBox1.Image = bmp;
        }
    }
}
