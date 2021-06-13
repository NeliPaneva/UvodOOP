using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabkAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            BanckAccount ba = new BanckAccount();
           
            Console.WriteLine(ba.ToString());

            BanckAccount ba2 = new BanckAccount(22,2000);

            Console.WriteLine(ba2.ToString());

            //ba.Balance = 675;
            //ba.Prin();
            //ba.Depozit(100);
            //ba.Prin();
            //ba.Withdraw(200);
            //Console.WriteLine(ba.ToString());
        }
    }
}
