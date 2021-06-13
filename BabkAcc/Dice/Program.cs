using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice mz = new Dice("glass");
            Dice mz2 = new Dice(12, "plasmas");
            Console.WriteLine(mz2.Sides);
            Console.WriteLine(mz2.Type);
            Dice mz3 = new Dice("wooden");
            Console.WriteLine(mz3.Sides);
            Console.WriteLine(mz3.Type);
        }
    }
}
