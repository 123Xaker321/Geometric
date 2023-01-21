using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    public class Circle: Shape
    {
        int x1 { get; set; }
        int x2 { get; set; }
        int y1 { get; set; }
        int y2 { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Circle circle &&
                   EqualityComparer<Brush>.Default.Equals(MyBrush, circle.MyBrush) &&
                   x1 == circle.x1 &&
                   x2 == circle.x2 &&
                   y1 == circle.y1 &&
                   y2 == circle.y2;
        }

        

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
