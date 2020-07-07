using System;

namespace FunWithStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount1 = new SavingAccount(1000);
            SavingAccount savingAccount2 = new SavingAccount(500);

            Console.WriteLine($"Interest Rate is: {SavingAccount.GetInterestRate()}");

            SavingAccount.SetInterestRate(0.005);
            SavingAccount savingAccount3 = new SavingAccount(1555.0);
            SavingAccount savingAccount5 = new SavingAccount(1555.0);
            SavingAccount savingAccount6 = new SavingAccount(1555.0);

            Console.WriteLine($"Interest Rate is: {SavingAccount.GetInterestRate()}");

            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            //TimeUtilClass timeUtilClass = new TimeUtilClass();          
        }
    }
}
