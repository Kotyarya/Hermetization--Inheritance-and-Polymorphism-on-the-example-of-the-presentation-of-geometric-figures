using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325
{
    public class Line : Point
    {

        public int x1 { get; protected set; }
        public int y1 { get; protected set; }

        public Line(int x, int y, int x1, int y1) : base(x, y)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.figurName = GeometricFigur.Line;

        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color,lineThickness))
            {
                pen.DashStyle = lineStyle;
                g.DrawLine(pen, x, y, x1, y1);
            }
        }

        public override void SetNewPosition(int x, int y)
        {

            this.x1 += x - this.x;
            this.y1 += y - this.y;
            this.x = x;
            this.y = y;
        }
    }
}
