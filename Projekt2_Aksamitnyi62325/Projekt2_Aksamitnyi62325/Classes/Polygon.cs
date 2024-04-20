using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Polygon : Rectangle
    {

        public int n { get; protected set; }  
        public Polygon(int x, int y, int width, int n) : base(x,y,width) 
        {
            this.n = n;   
            switch (n)
            {
                case 3:
                    this.figurName = GeometricFigur.Triangle;
                    break;
                case 4:
                    this.figurName = GeometricFigur.Diamond;
                    break;
                case 5:
                    this.figurName = GeometricFigur.Pentagon; 
                    break;
                case 6:
                    this.figurName = GeometricFigur.Hexagon; 
                    break;
                case 8:
                    this.figurName = GeometricFigur.Octagon;
                    break;
                        
            }
        }

        public Polygon(int x, int y, int width, int n, Color color) : this(x,y,width,n)
        {
            this.color = color;
        }


        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[n];
                
                for (int i = 0; i < n; i++)
                {
                    double X = x + (width / 2) * Math.Cos((2*Math.PI*i)/n);
                    double Y = y + (width / 2) * Math.Sin((2 * Math.PI * i) / n);
                    points[i] = new PointF((float)X,(float)Y);
                }
                
                g.DrawPolygon(pen, points);
            }
        }
    }
}
