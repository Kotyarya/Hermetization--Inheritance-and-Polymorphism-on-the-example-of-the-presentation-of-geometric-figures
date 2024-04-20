using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Square : Rectangle
    {
        public Square(int x, int y, int width) : base(x, y, width)
        {
            this.figurName = GeometricFigur.Square;
        }
    }
}
