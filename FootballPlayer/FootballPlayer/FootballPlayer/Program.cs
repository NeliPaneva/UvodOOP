using System;

namespace FootballPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            FootballPlayer player1 = new FootballPlayer(name, age);

            Console.WriteLine($"{player1.Name} is {player1.Age} years old.");

        }
    }
}
