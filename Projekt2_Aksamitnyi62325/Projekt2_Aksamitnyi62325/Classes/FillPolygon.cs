using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class FillPolygon : Polygon
    {

        public FillPolygon(int x, int y, int width, int n ): base(x,y,width,n)
        {
            this.n = n;
            this.x = x;
            this.y = y;
            this.width = width;
        }


        public override void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(color))
            { 
                PointF[] points = new PointF[n];

                for (int i = 0; i < n; i++)
                {
                    double X = x + (width / 2) * Math.Cos((2 * Math.PI * i) / n);
                    double Y = y + (width / 2) * Math.Sin((2 * Math.PI * i) / n);
                    points[i] = new PointF((float)X, (float)Y);
                }

                g.FillPolygon(brush, points);
            }
        }

        public void SetNewAttributes(Color color)
        {
            this.color = color;
        }
    }
}
