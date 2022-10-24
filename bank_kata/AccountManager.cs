namespace bank_kata
{
    public class AccountManager : IManageAccount
    {
        private BankAccount _bankAccount;

        public AccountManager(string name)
        {
            _bankAccount = new BankAccount(name);
        }

        public string AccountName => throw new NotImplementedException();
        public double Balance => throw new NotImplementedException();

        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }

        public void ResetAccount()
        {
            _bankAccount.Balance = 0;
        }
    }
}