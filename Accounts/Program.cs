using Accounts.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Accounts {
    internal class Program {
        static void Main(string[] args) {

            // Abstract test
            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 1500.0, 500.0));
            accounts.Add(new SavingsAccount(1003, "Bob", 700.0, 0.015));
            accounts.Add(new BusinessAccount(1004, "Anna", 1200.0, 1000.0));

            // Totaliza accounts
            double sum = 0.0;
            foreach (Account acc in accounts) {
                sum += acc.Balance;
            }
            Console.WriteLine($"Saldo das contas: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            // Witchdraw 10.0
            foreach (Account acc in accounts) {
                acc.Withdraw(10.0);
                Console.WriteLine($"Saldo da conta {acc.Number}: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            // Polimorfism test
            /*Account acc1 = new Account(1001, "Alex Green", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria Yellow", 500.0, 0.01);
            Account acc3 = new BusinessAccount(1003, "Bob Blue",  500.0,  1000.0);
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            acc3.Withdraw(10.0);
            Console.WriteLine($"Saldo Conta Corrente: {acc1.Balance}");
            Console.WriteLine($"Saldo Conta Poupança: {acc2.Balance}");
            Console.WriteLine($"Saldo Conta Empresa: {acc3.Balance}");*/

            // Upcast and Downcast test
            /*Account acc = new Account(1001, "Alex Green", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria Yellow", 0.0, 500.0);

            // Upcasting (subclasse para superclasse)
            Account acc2 = bacc;
            Account acc3 = new BusinessAccount(1003, "Anna Red", 0.0, 200.0);
            Account acc4 = new SavingsAccount(1004, "Bob Blue", 0.0, 0.1);

            // Downcasting (superclasse para subclasse)
            BusinessAccount acc5 = (BusinessAccount)acc3;
            acc5.Loan(100.0);
            // BusinessAccount acc6 = (BusinessAccount)acc4; // erro
            if (acc4 is BusinessAccount) {
                BusinessAccount acc6 = (BusinessAccount)acc4;
                acc6.Loan(200.0);
                Console.WriteLine("Empréstimo concedido!");
            }
            if (acc4 is SavingsAccount) {
                SavingsAccount acc6 = acc4 as SavingsAccount;
                acc6.UpdateBalance();
                Console.WriteLine("Saldo Atualizado!");
            }*/
        }
    }
}
