using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Rectangle : Point
    {


        public int height { get; protected set;}
        public int width { get; protected set;}



        public Rectangle(int x, int y, int width) : base(x, y)
        {
            this.width = width;   
            this.height = width;
            this.figurName = GeometricFigur.Rectangle;
        }
        public Rectangle(int x, int y, int width, int height) : this(x,y,width) 
        {
            this.height = height;
        }


        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;

                PointF[] points = new PointF[4];

                points[0] = new PointF(x, y);
                points[1] = new PointF(x + width, y);
                points[2] = new PointF(x + width, y + height);
                points[3] = new PointF(x, y + height);

                g.DrawPolygon(pen, points);
            }
        }
    }
}
