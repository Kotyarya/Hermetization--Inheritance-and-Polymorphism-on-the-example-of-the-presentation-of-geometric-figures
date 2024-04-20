using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Triangle : Polygon
    {

        public int x2 { get; private set; }
        public int y2 { get; private set; }
        public Triangle(int x, int y,int x2, int y2) : base(x,y,0,3) 
        {
            this.figurName = GeometricFigur.Triangle;
            this.x2 = x2;
            this.y2 = y2;
        }


        public override void SetNewPosition(int x, int y)
        {
            int rangeX = this.x - x;
            int rangeY = this.y - y;
            this.x = x;
            this.y = y;
            this.x2 = this.x2 - rangeX;
            this.y2 = this.y2 -  rangeY;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[3];

                points[0] = new PointF(x > x2 ? x2 + ((x - x2) / 2) : x + ((x2 - x) / 2), y > y2 ? y2 : y);
                points[1] = new PointF(x > x2 ? x : x2, y > y2 ? y : y2);
                points[2] = new PointF(x > x2 ? x2 : x, y > y2 ? y : y2);

                g.DrawPolygon(pen, points);
            }
        }
    }
}
