namespace bank_kata
{
    public interface IManageAccount
    {
        string AccountName { get; }
        double Balance { get; }

        public void ResetAccount();

        public void Deposit(double amount);

        public void Withdraw(double amount);
    }
}