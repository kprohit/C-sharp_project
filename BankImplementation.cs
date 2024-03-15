using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects1
     
{
   class BankImplementation : BankInterface
    {

        int Balance = 25000;

        public  void CheckBalance(int pin)
        {
            if (pin == 777)
            {
                Console.WriteLine("Your balance is {0}", Balance);
            }
            else
            {
                Console.WriteLine("Enter the correct pincode");
            }

          
        }

        public  void Credit(int amt,int pin)
        {
            if (pin == 777)
            {
                Balance += amt;
                CheckBalance(pin);
            }
            else
            {
                Console.WriteLine("Enter the correct pincode");
            }
           
        }
        
        public  void Debit(int amt,int pin)
        
        {

            if (pin == 777)
            {
                Balance -= amt;
                CheckBalance(pin);
            }
            else
            {
                Console.WriteLine("Enter the correct pincode");
            }
          
        }

        public  void Login(int pin)
        {
           if(pin==777)
            {
                 
               
            }
            else
            {
                Console.WriteLine("Enter the correct pincode");
            }


        }
        public void BankInfo()
        {
            Console.WriteLine("Your Bank Name is Bank of Baroda");
        }
    }
}
