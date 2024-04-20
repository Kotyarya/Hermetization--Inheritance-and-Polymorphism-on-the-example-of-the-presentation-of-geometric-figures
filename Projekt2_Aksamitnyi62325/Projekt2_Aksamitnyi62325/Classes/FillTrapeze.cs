using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class FillTrapeze : Trapeze
    {

        public FillTrapeze(int x,int y,int width, int height ) : base(x,y,width, height)
        {
			this.y = y;
			this.x = x;
			this.width = width;
			this.height = height;
		}



		public override void Draw(Graphics g)
		{
			using (SolidBrush brush = new SolidBrush(color))
			{ 
				PointF[] points = new PointF[4];


                points[0] = new PointF(x + (width / 3), y);
                points[1] = new PointF(x + 2 * (width / 3), y);
                points[2] = new PointF(x + width, y + height);
                points[3] = new PointF(x, y + height);


                g.FillPolygon(brush, points);
			}
		}
	}
}
