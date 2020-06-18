//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

namespace _11BankAccountData
{
    class BankAcoountData
    {
        static void Main()
        {
            string firstName = "Pesho";
            string middleName = "Goshev";
            string lastName = "Peshev";
            decimal balanceAmount = 365.123m;
            string bankName = "First Bank";
            string iban = "123456789";
            string creditCardNum = "9876543";

            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Middle name: {0}", middleName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Balance: {0}", balanceAmount);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("credit card number: {0}", creditCardNum);
        }
    }
}
