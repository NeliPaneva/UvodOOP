using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person firstPerson = new Person("Martin");

            //firstPerson.IntroduceYourself();
            //Console.WriteLine(   firstPerson.NameLength());
            //firstPerson.Name = "Mitko";
            //firstPerson.PrintNameLength();

            //firstPerson.Name = "Гошо";
            //firstPerson.Age = 15;

            //firstPerson.IntroduceYourself();

            //Person secondPerson = new Person( 7);
            //secondPerson.IntroduceYourself();

            //Person thirdPerson = new Person();
            //thirdPerson.IntroduceYourself();
            int[] a = new int[25];//  23 45 33 44
            Person[] ekip = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("vavedete ime:");
                string n = Console.ReadLine();
                Console.WriteLine("vavedete godini:");
                int g = int.Parse(Console.ReadLine());
                Person perko = new Person(n, g);
                ekip[i] = perko;
            }
            for (int i = 0; i < 3; i++)
            {
                ekip[i].IntroduceYourself();
            }
        }
    }
}
