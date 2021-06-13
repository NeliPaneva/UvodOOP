using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Guest
    {
        private string name;
        private string egn;
        private string pay;
        private int countNights=1;
        private decimal price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Egn
        {
            get { return egn; }
            set { egn = value; }
        }
        
        public string Pay
        {
            get { return pay; }
            set { pay = value; }
        }

        public int CountNights

        {
            get { return countNights; }
            set { countNights = value; }
        }
   
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Guest(string name, string egn)
        {
            this.Name = name;
            this.Egn = egn;
        }
        public Guest(string name, string egn, int cn):this(name,egn)
        {
            this.CountNights = cn;
        }

        public void SetPrise()
        {
            Console.WriteLine("Задайте цена за една нощ:");
            decimal d = decimal.Parse(Console.ReadLine());
            this.Price = d;
        }

    }
}
