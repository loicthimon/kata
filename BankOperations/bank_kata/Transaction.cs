namespace bank_kata
{
    public class Transaction : IStoreTransaction
    {
        public double Amount { get; set; }
        public DateTime Datetime { get; set; }
        public double Balance { get; set; }

        public Transaction(DateTime dateTime, double amount, double balance)
        {
            Amount = amount;
            Datetime = dateTime;
            Balance = balance;
        }

        public double Execute()
        {
            throw new NotImplementedException();
        }
    }
}
