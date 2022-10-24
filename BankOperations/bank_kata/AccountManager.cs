namespace bank_kata
{
    public class AccountManager : IManageAccount
    {
        private readonly BankAccount _bankAccount;

        public double Balance => _bankAccount.Balance;

        public IReadOnlyList<IStoreTransaction> Operations => _bankAccount.Transactions;

        public AccountManager(string name)
        {
            _bankAccount = new BankAccount(name);
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException();

            _bankAccount.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0 || _bankAccount.Balance - amount < 0)
                throw new ArgumentOutOfRangeException();

            _bankAccount.Balance -= amount;
        }

        public void DisplayOperations()
        {
            foreach (var transaction in _bankAccount.Transactions)
            {
                
                Console.WriteLine($"DateTime {transaction.Datetime.ToString("G")} Amount {transaction.Amount} Balance {transaction.Balance}");
            }
        }

        public void ResetAccount()
        {
            _bankAccount.Balance = 0;
            _bankAccount.Transactions.Clear();
        }
    }
}