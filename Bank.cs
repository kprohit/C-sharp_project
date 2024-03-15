using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects1
{
 abstract class Bank
    {
      internal  int Balance = 25000;
        abstract public void Credit(int Amt,int pin);
        abstract public void Debit(int Amt, int pin);

        public static explicit operator Bank(BankImplementation v)
        {
            throw new NotImplementedException();
        }

        abstract public void Login(int pin);

        abstract public void CheckBalance(int pin);

       
        internal void BankInfo()
        {
            Console.WriteLine("This is a Bank of Baroda");
        }
    }
}
