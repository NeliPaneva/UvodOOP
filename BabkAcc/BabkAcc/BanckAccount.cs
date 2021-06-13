using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabkAcc
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

        public BanckAccount()
        {
            this.Id = 1;
            this.Balance = 10;
        }

        public BanckAccount(int nomer, decimal suma)
        {
            this.Id = nomer;
            this.Balance = suma;
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
        public  void Prin()
        {
            Console.WriteLine( $"Smetka {this.Id} ima {this.Balance} leva.");
        }
    }
}
