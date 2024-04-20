using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Rhombus : Rectangle
    {



        public Rhombus(int x, int y, int width) : base(x, y, width)
        {
            this.figurName = GeometricFigur.Rhombus;
        }

        public Rhombus(int x, int y, int width, int height) : this(x, y, width)
        {
            this.height = height;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[4];

                points[0] = new PointF(x + (width / 2), y);
                points[1] = new PointF(x + width, y + (height / 2));
                points[2] = new PointF(x + (width / 2), y + height);
                points[3] = new PointF(x, y + (height / 2));


                g.DrawPolygon(pen, points);
            }
        }
    }
}
