using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsultacia
{
    class Animal
    {
        private string type;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int legs;

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        private double weight;

        private double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Animal()
        {
            this.Type = "jivotno";
            this.Legs = 4;
        }
        public Animal(string t, int age)
        {
            this.Type = t;
            this.Age = age;

        }
        public Animal(int l, string t)
        {
            this.Type = t;
            this.Legs = l;
        }
        public Animal(string t, int age, int legs, double weight) : this(t, age)
        {
            this.Legs = legs;
            this.Weight = weight;
        }

       internal  void Eat(double food)
        {
            this.Weight += this.Weight * 0.02;
        }

        public override string ToString()
        {
            return $"тип {Type} на {Age}   месеца с {Legs}   крака и  тежи {Weight}  кг. ";
        }
    }
}
