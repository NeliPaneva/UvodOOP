using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointRectangle
{
    public class Rectangle
    {
        Point topLeft;
        Point bottomRight;
        public Rectangle(Point p,Point v)
        {
            this.topLeft = p;
            this.bottomRight = v;
        }
        public bool Contains(Point point)
        {
            if (point.X >= topLeft.X && point.X <= bottomRight.X && point.Y <= bottomRight.Y && point.Y >= topLeft.Y)
            {
                return true;
            }
            else return false;
        }
    }
}
