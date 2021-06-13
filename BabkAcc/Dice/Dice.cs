using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        public int sides;
        string type;
        private string collor;

        public string Collor
        {
            get { return collor; }
            set { collor = value; }
        }

        public int Sides
        {
            get {return this.sides; }
            set {this.sides=value; }
        }
        public string Type
        {
            get {return this.type; }
            set {this.type=value; }
        }

        public Dice(int s, string t,string collor): this (s, t)
        {
            this.Collor = collor;
        }


        public Dice(int s, string t)
        {
            this.Sides = s;
            this.Type = t;
        }
        public Dice(string t)
        {
            this.Sides = 6;
            this.Type = t;
        }

        private Random rnd = new Random();
        public int Roll()
        {
            int rollResult = rnd.Next(1, this.sides + 1);
            return rollResult;
        }
        
    }
}
