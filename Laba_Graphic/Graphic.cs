using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_Graphic
{
    class Graphic
    {
        Graphics graph;
        Point xy0;

        public Graphic(Graphics g, Size size, Point cur)
        {
            this.graph = g;
            xy0=new Point(size.Width / 2,size.Height / 2);
        }

        public void Draw()
        {
            drawAxes();
        }
        void drawAxes()
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            graph.DrawLine(Pens.Black,0,xy0.Y, xy0.X* 2, xy0.Y);
            graph.DrawLine(Pens.Black, xy0.X, 0, xy0.X, xy0.Y* 2);

        }
    }
}
