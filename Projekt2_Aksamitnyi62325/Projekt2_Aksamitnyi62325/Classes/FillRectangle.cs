using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class FillRectangle : Rectangle
    {


        public FillRectangle(int x, int y, int width) : base(x, y, width)
        {
            this.y = y;
            this.width = width;
            this.height = width;
            this.x = x;
            this.figurName = GeometricFigur.Rectangle;
        }

        public FillRectangle(int x, int y, int width, int height) : this(x, y, width) 
        {
            this.height = height;
        }



        public override void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                PointF[] points = new PointF[4];

                points[0] = new PointF(x, y);
                points[1] = new PointF(x + width, y);
                points[2] = new PointF(x + width, y + height);
                points[3] = new PointF(x, y + height);
                
                g.FillPolygon(brush,points);
            }
        }
    }
}
