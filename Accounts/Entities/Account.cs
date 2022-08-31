namespace Accounts.Entities {
    public class Account {
        // Attributes
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        // Constructors
        public Account() { }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Methods
        public void Deposit(double amount) {
            Balance += amount;
        }

        public virtual void Withdraw(double amount) {
            Balance -= amount + 5.0;
        }
    }
}
