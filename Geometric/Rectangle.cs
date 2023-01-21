using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    public class Rectangle: Shape
    {
        int x1 { get; set; }
        int x2 { get; set; }
        int y1 { get; set; }
        int y2 { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
                   EqualityComparer<Brush>.Default.Equals(MyBrush, rectangle.MyBrush) &&
                   x1 == rectangle.x1 &&
                   x2 == rectangle.x2 &&
                   y1 == rectangle.y1 &&
                   y2 == rectangle.y2;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
