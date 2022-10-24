namespace bank_kata
{
    public class BankAccount
    {
        public string Name { get; private set; }
        public double Balance { get; set; } = 0;
        public List<IStoreTransaction> Transactions { get; set; }

        public BankAccount(string name)
        {
            Name = name;
            Transactions = new List<IStoreTransaction>();
        }
    }
}