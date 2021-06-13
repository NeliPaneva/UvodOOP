using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private int age;
        private Person parent1;

        public Person Parent1
        {
            get { return parent1; }
            set { parent1 = value; }
        }
        public String Name
        { //реализираме свойство Name
            get { return name; }
            set { name = value; }
        }
        public int Age
        { //реализираме свойство Age
            get { return age; }
            set { age = value; }
        }

        public Person()
        {
            this.Name = "Human";
            this.Age = 1;
        }
        public Person(string n)
        {
            this.Name = n;
        }
        public Person(int a)
        {
            this.Age = a;
        }
        public Person(string n, int a)
        {
            this.Name = n;
            this.Age = a;
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
           
            Console.WriteLine("Здравейте, Аз съм {0} ио съм на {1} години", name, age);
            Console.WriteLine($"Здравейте, Аз съм {this.Name} ио съм на {this.Age} години");
            

        }
        public int NameLength()
        {
            int len = this.Name.Length;
            return len;
        }
        public void PrintNameLength()
        {
            int len = this.Name.Length;
            Console.WriteLine(len); 
        }

    }
}
