using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Trapeze : Rectangle
    {


        public Trapeze(int x, int y, int width, int height) : base(x,y, width, height)
        {
            this.figurName = GeometricFigur.Trapeze;
        }


        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[4];

                points[0] = new PointF(x + (width / 3) , y);
                points[1] = new PointF(x + 2 * (width / 3), y);
                points[2] = new PointF(x + width, y + height);
                points[3] = new PointF(x, y + height);


                g.DrawPolygon(pen, points);
            }
        }
    }
}
