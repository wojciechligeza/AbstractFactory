using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accountNumbers = new List<string>
            {
                "ING",
                "PKO",
                "Alior"
            };

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                AccountAbstractFactory abstractFactory = AccountFactoryProvider.GetAccountAbstractFactory(accountNumbers[i]);

                if (abstractFactory == null)
                {
                    Console.WriteLine("Przepraszamy. To konta " +
                                      " '{0}' jest niepoprawne.", (accountNumbers[i]));
                }
                else
                {
                    abstractFactory.CreateLoanAccount();
                    abstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadKey();
        }
    }
}
