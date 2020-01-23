namespace AbstractFactory
{
    public class AccountFactoryProvider
    {
        public static AccountAbstractFactory GetAccountAbstractFactory(string accountNumber)
        {
            if (accountNumber.Contains("ING"))
            {
                return new IngAccountFactory();
            }
            else if (accountNumber.Contains("PKO"))
            {
                return new PkoAccountFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
