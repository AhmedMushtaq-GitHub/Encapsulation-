using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation
{
    internal class Security
    {
        private string name;
        private int balance;

       public void setName(string Name)
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("invalid Name");
                
            }
            else 
            {
                this.name = Name;
            }
           
        }
        public void getName()
        {
            Console.Write($"{ this.name} Your Belance is : ");
        }

        public void setBalance(int Balance) 
        { 
            this.balance = Balance;
        }
        public void getBalance()
        {
            if (string.IsNullOrEmpty(this.name) == true)
            {
                Console.WriteLine("input your name");

            }
            else
            Console.Write(this.balance);
            
            
        }
    }
}
