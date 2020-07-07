using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithStatic
{
    class SavingAccount
    {
        public double currBalance;

        public static double currInterestRate = 0.04;

        public SavingAccount(double balance) 
        {
            currBalance = balance;
        }

        public static void SetInterestRate(double newRate) 
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate() 
        {
            return currInterestRate;        
        }
    }
}
