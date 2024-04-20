using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class TwoWayLine : Line
    {


        public TwoWayLine(int x, int y, int x1, int y1) : base(x,y,x1,y1)
        {
            this.figurName = GeometricFigur.Line;
        }


        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(pen, x, y, x1, y1);
            }
        }
    }
}
