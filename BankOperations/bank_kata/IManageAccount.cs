namespace bank_kata
{
    public interface IManageAccount
    {
        public double Balance { get; }
        public IReadOnlyList<IStoreTransaction> Operations { get; }
        public void DisplayOperations();

        public void Deposit(double amount);

        public void Withdraw(double amount);

        public void ResetAccount();
    }
}