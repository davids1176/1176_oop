using System;
namespace Lada_OOP
{
    public class BankAccount
    {
        private int balance;
        private string preNumber;
        private string accountNumber;
        private int bankCode;

        private string Bank { get; set; }

        public string FullAccountName
        {
            get { return $"{preNumber}-{accountNumber}/{bankCode}"; }
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdrawal(int amount)
        {
            if(balance - amount >= -1000)
            {
                balance -= amount;
            }
        }
        
        public BankAccount(int balance, string preNumber, string accountNumber, int bankCode)
        { 
            this.balance = balance;
            this.preNumber = preNumber;
            this.accountNumber = accountNumber;
            this.bankCode = bankCode;
            this.Bank = Bank;
        }

        public BankAccount()
        {
        }
    }
}
