using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   public class Animal
    {
        protected string poroda;
        private int age;
        
        public Animal(string po,int a)
        {
            this.poroda = po;
            this.age = a;
        }
        public void Eat()
        {
            Console.WriteLine("Animal eat.");
        }
        public override string ToString()
        {
            return $"{poroda}   {age}";
        }

    }
}
