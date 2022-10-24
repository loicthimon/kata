namespace bank_kata
{
    public class BankAccount
    {
        public string Name { get; private set; }
        public double Balance { get; set; }

        public BankAccount(string name)
        {
            Name = name;
        }
    }

}