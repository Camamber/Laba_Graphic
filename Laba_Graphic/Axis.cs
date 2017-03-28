using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_Graphic
{
    class Axis
    {
        Graphics graph;
        Point xy0;

        public Axis(Graphics g, Size size, Point cur)
        {
            this.graph = g;
            xy0 = new Point(size.Width / 2, size.Height / 2);
        }

        public void Draw()
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            graph.DrawLine(Pens.Black, 0, xy0.Y, xy0.X * 2, xy0.Y);
            graph.DrawLine(Pens.Black, xy0.X, 0, xy0.X, xy0.Y * 2);

        }
    }
}
