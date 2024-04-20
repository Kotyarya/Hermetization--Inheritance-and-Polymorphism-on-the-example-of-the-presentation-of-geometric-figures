using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Circle : Square
    {

        public Circle(int x, int y, int width) : base(x,y,width)
        {
            this.figurName = GeometricFigur.Circle;
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
