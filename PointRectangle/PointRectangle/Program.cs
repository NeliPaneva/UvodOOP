using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] koord = Console.ReadLine().Split( );
            int a = int.Parse(koord[0]);
            int b = int.Parse(koord[1]);
            int c = int.Parse(koord[2]);
            int d = int.Parse(koord[3]);
            Point parva = new Point(a, b);
            Point vtora = new Point(c, d);
            Rectangle rec = new Rectangle(parva, vtora);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] koordPoint = Console.ReadLine().Split();


                int aP = int.Parse(koordPoint[0]);
                int bP = int.Parse(koordPoint[1]);
                Point p = new Point(aP, bP);
                Console.WriteLine(rec.Contains(p));
            }


        }
    }
}
