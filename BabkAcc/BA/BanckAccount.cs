using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
   public  class BanckAccount
    {
        private int id;
        private decimal balance;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
      
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void Depozit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance >= amount) { this.Balance -= amount; }
            else Console.WriteLine("Nevazmogno teglene");
        }

        public override string ToString()
        {
            return $"Smetka {this.Id} ima {this.Balance} leva.";
        }

       
    }
}
