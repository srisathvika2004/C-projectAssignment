using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    class BankAccount
    {
        private int Balance;

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine("the balane is:" + Balance);
            }
            else
            {
                Console.WriteLine("Please enter positive amount");
            }
        }
        public void Withdraw(int amount)
        {
            if (Balance > amount)
            {
                Balance = Balance - amount;
                Console.WriteLine("The left balance is:" + Balance);

            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
        public int GetBalance()
        {
            return Balance;
        }
    }
}
