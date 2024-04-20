using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class FillCircle : Circle
    {

        public FillCircle(int x, int y, int width) : base(x, y, width)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = width;
        }

        public override void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, x, y, width, height);
            }
        }
    }
}
