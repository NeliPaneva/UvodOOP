using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dogi = new Dog("ovcharka", 2, "Sharo");
            Dog kuche = new Dog("koli", 3, "Mecho", "Yelow");
            dogi.Bark();
            dogi.Eat();
            Console.WriteLine(dogi);
            Console.WriteLine(kuche);
        }
    }
}
