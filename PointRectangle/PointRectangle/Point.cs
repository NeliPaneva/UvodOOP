using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointRectangle
{
   public class Point
    {
        int x;
        int y;
        public int X { get { return this.x; }  }
        public int Y { get { return this.y; }  }
        public Point(int abs, int ord)
        {
            this.x = abs;
            this.y = ord;
        }
    }
}
