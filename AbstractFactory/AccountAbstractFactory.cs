namespace AbstractFactory
{
    // FABRYKA ABSTRAKCYJNA
    public abstract class AccountAbstractFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }

    // PRODUKT ABSTRAKCYJNY A
    public interface ILoanAccount { }

    // PRODUKT ABSTRAKCYJNY B
    public interface ISavingsAccount { }
}
