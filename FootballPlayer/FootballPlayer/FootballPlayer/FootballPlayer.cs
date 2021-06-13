using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayer
{
    class FootballPlayer
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || value.Length == 0) throw new ArgumentException("The name cannot be null or empty");
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 18 || value > 28) throw new ArgumentException("The age must be between 18 and 28 ages.");
                this.age = value;
            }
        }

        public FootballPlayer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
