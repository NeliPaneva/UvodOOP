using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsultacia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> myList = new List<Animal>();
            Animal a1 = new Animal();
            myList.Add(a1);

            Animal a = new Animal("Riba",2);
            myList.Add(a);

            Animal b = new Animal( 6,"nasekomo");
            myList.Add(b);

            Animal c = new Animal("rabit", 3, 4, 3.45);
            myList.Add(c);

            Console.WriteLine(String.Join("\n",myList));

            c.Eat(20.3);
            Console.WriteLine(c);
        }
    }
}
