using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    class Bank
    {
        public static double InterestRate { get; private set; }

        // Static method
        public static void SetInterestRate(double rate)
        {
            InterestRate = rate;
        }

        public double CalculateInterest(double amount)
        {
            return amount * InterestRate;
        }
    }
}
