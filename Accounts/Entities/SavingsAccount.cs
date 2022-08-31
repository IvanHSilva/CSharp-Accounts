using System;
using System.Runtime.Remoting.Messaging;

namespace Accounts.Entities {
    public class SavingsAccount : Account {
        // Attributes
        public double InterestRate { get; set; }

        // Constructors
        public SavingsAccount() {}

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance) {
            InterestRate = InterestRate;
        }

        // Methods
        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) {
            Balance -= amount;
        }
    }
}
