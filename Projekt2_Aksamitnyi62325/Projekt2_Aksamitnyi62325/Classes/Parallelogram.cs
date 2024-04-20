using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Parallelogram : Point
    {

        public int width { get; protected set; }
        public int height { get; protected set; }   

        public Parallelogram(int x, int y, int width, int height) : base(x,y)
        {
            this.y = y;
            this.x = x;
            this.width = width;
            this.height = height;
        }

        public Parallelogram(int x, int y, int width, int height, Color color) : this(x,y,width,height)
        {
            this.color = color;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[4];


               points[0] = new PointF(this.x + (this.width / 3),this.y - height);
                points[1] = new PointF(this.x + 2*(this.width / 3), this.y - height);
                points[2] = new PointF(this.x + this.width, this.y);
                points[3] = new PointF(this.x, this.y);


                g.DrawPolygon(pen, points);

                isVisible = true;
            }
        }
    }
}
