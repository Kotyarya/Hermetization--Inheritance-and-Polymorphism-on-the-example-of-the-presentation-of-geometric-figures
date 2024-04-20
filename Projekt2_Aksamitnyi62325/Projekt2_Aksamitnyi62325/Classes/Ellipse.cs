using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Ellipse : Rectangle
    {

        public Ellipse(int x,int y, int width): base(x,y, width)
        {
            this.figurName = GeometricFigur.Ellipse;
        }   


        public Ellipse(int x, int y, int width, int height) : this(x, y, width)
        {
            this.height = height;
        }


        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                g.DrawEllipse(pen, x, y, width, height);
            }
        }
    }
}
