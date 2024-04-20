using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class CurveLine : Point
    {

        public List<PointF> points { get; private set; } = new List<PointF>();
        public CurveLine(int x, int y) : base(x,y)
        {
            figurName = GeometricFigur.Line;
        }



        public void AddPoint(int x, int y)
        {
            points.Add(new PointF(x,y));
        }

        public override void SetNewPosition(int x, int y)
        {
            int rangeX = (int)points[0].X - x;
            int rangeY = (int)points[0].Y - y;
            points[0] = new PointF(x, y);

            for (int i = 1; i < points.Count; i++)
            {
                points[i] = new PointF(points[i].X - rangeX, points[i].Y - rangeY);
            }
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    g.DrawLine(pen, points[i], points[i + 1]);
                }
            }
            
        }
    }
}
