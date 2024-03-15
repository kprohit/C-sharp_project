using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects1
{
     interface BankInterface
     {  
         void Credit(int Amt,int pin);

         void Debit(int Amt, int pin);
         void Login(int pin);

         void CheckBalance(int pin);

          void BankInfo();        
    }
}
