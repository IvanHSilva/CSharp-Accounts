namespace Accounts.Entities {
    public class BusinessAccount : Account {
        // Attributes
        public double LoanLimit { get; set; }

        // Constructor
        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) {
            LoanLimit = loanLimit;
        }

        // Methods
        public void Loan(double amount) {
            if (amount <= LoanLimit) Balance += amount;
        }

        public override void Withdraw(double amount) {
            base.Withdraw(amount);
            Balance -= 5.0;
        }
    }
}
