using System;

namespace AbstractFactory
{
    // KONKRETNY PRODUKT A1
    public class IngSavingsAccount : ISavingsAccount
    {
        public IngSavingsAccount()
        {
            Console.WriteLine("Numer konta ING: 125367823");
        }
    }

    // KONKRETNY PRODUKT B1
    public class IngLoanAccount : ILoanAccount
    {
        public IngLoanAccount()
        {
            Console.WriteLine("Numer pożyczki ING: 89878912");
        }
    }

    // KONKRETNA FABRYKA 1
    public class IngAccountFactory : AccountAbstractFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            return new IngLoanAccount();
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            return new IngSavingsAccount();
        }
    }
}
