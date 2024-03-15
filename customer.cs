using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects1
{
    class customer
    {
        public static void Main(string[] args)
        {
            int credit=0,debit=0;
            int OptionNo;

            Bank obj = (Bank) new BankImplementation();

            Console.WriteLine("enter the password of 3 numbers");
            int pin1 = Convert.ToInt32(Console.ReadLine());

            //obj.CheckBalance(pin1);
            do
            {   
                Console.WriteLine("\n");

               Console.WriteLine("1:Credit Amount  \n2:debit Amount  \n3:CheckBalance \n4:BankInfo \n5: Exit");
                OptionNo = Convert.ToInt32(Console.ReadLine());
        

            switch (OptionNo)
            {    
                case 1: Console.WriteLine("enter the amount you want to credit");
                   credit= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("after performing the credit operation");
                    obj.Credit(credit, pin1);
                    break;

                case 2:
                    Console.WriteLine("enter the amount you want to debit");
                    debit= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("after performing the Debit operation");
                    obj.Debit(debit, pin1);
                    break;

                case 3: obj.CheckBalance(pin1);
                    break;

                    case 4: obj.BankInfo(); break;
                    case 5:
                        Console.WriteLine("press any key to exit");
                        break;
            }
            } while (OptionNo != 5);



            Console.ReadKey();
        }
    }
}
