namespace bank_kata
{
    public interface IStoreTransaction
    {
        public double Amount { get; set; }
        public DateTime Datetime { get; set; }
        public double Balance { get; set; }
        public double Execute();
    }
}
