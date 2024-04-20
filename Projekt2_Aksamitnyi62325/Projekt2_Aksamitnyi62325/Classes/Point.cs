using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325
{
    public class Point
    {
        public enum GeometricFigur : byte
        {
            Point,
            Line,
            Square,
            Ellipse,
            Circle,
            Rectangle,
            Triangle,
            Trapeze,
            Diamond,
            Rhombus,
            Pentagon,
            Hexagon,
            Octagon
        }

        public enum GeometricFigurWithLocation : byte
        {
            Point,
            Line,
            Square,
            Ellipse,
            Circle,
            Rectangle,
            Triangle,
            Rhombus,
            CurveLine,
            BazierLine,
            TwoWayLine
        }


        public GeometricFigur figurName { get; protected set;}
        public int x { get; protected set;}
        public int y { get; protected set;}
        public Color color { get; protected set;}  
        public DashStyle lineStyle { get; protected set;}   
        public float  lineThickness { get; protected set;}  

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y; 
            figurName = GeometricFigur.Point;
            color = Color.Black;
            lineStyle = DashStyle.Solid;
            lineThickness = 5f;
        }

        public Point(int x, int y, Color color) : this(x,y)
        {
            this.color = color;
        }

        public virtual void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, x, y, 10,10);
            }
        }

        public virtual void SetNewPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void SetNewAttributes(Color color, DashStyle lineStyle, float lineThickness)
        {
            this.color = color;
            this.lineStyle = lineStyle;
            this.lineThickness = lineThickness; 
        }
    }
}
