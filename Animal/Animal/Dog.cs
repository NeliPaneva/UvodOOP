using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Dog:Animal
    {
        string name;
        string okraska;
        public Dog(string po,int a, string n):base(po,a)
        {
            //this.poroda = "Lobrador";
            this.name = n;
        }
        public Dog(string po, int a, string n, string o) : this(po, a,n)
        {
            
            this.okraska = o;
        }
        public void Bark()
        {
            Console.WriteLine("BAY-BAY-BAY");
        }
        public override string ToString()
        {
            return $"{this.poroda}  {this.name}   {this.okraska}";
        }
    }
}
