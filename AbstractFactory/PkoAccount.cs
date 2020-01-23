using System;

namespace AbstractFactory
{
    // KONKRETNY PRODUKT A2
    public class PkoSavingsAccount : ISavingsAccount
    {
        public PkoSavingsAccount()
        {
            Console.WriteLine("Numer konta PKO BP: 74862789");
        }
    }

    // KONKRETNY PRODUKT B2
    public class PkoLoanAccount : ILoanAccount
    {
        public PkoLoanAccount()
        {
            Console.WriteLine("Numer pożyczki PKO BP: 43179832");
        }
    }

    // KONKRETNA FABRYKA 2
    public class PkoAccountFactory : AccountAbstractFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            return new PkoLoanAccount();
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            return new PkoSavingsAccount();
        }
    }
}
