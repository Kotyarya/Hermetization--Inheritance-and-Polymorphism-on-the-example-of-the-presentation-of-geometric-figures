using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class FillTriangle : Triangle
    {

        public FillTriangle(int x, int y, int x2, int y2) : base(x, y, x2, y2) { }


        public override void Draw(Graphics g)
        {
            using (SolidBrush pen = new SolidBrush(color))
            { 
                PointF[] points = new PointF[3];

                points[0] = new PointF(x > x2 ? x2 + ((x - x2) / 2) : x + ((x2 - x) / 2), y > y2 ? y2 : y);
                points[1] = new PointF(x > x2 ? x : x2, y > y2 ? y : y2);
                points[2] = new PointF(x > x2 ? x2 : x, y > y2 ? y : y2);

                g.FillPolygon(pen, points);
            }
        }
    }
}
