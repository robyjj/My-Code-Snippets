using System;
using System.Collections;

namespace Snippets
{
    public delegate void BalanceChangeEventHandler();
    public class EventsBankAccount
    {       
        public static void Run()
        {            
            BankAccount account = new BankAccount("Test", 30);
            BalanceChangeEventHandler bc = new BalanceChangeEventHandler(account.ShowBalance);
            account.BalanceChanged += bc;
            account.ShowBalance();
            account.Deposit(20);
            //Console.ReadLine();
            account.Deposit(30);
            //Console.ReadLine();
            account.Withdraw(40);
            Console.ReadLine();
        }
        
    }

    public class BankAccount
    {
        
        public event BalanceChangeEventHandler BalanceChanged;
        public string Name { get; set; }
        private double _balance;
        public double Balance { get { return _balance; } 
            set 
            {
                _balance = value;
                OnBalanceChanged();
            }
        }
        public BankAccount(string Name,double Balance)
        {
            this.Name = Name;
            this.Balance = Balance;
            //BalanceChanged = new BalanceChangeEventHandler(ShowBalance);           
        }
        protected void OnBalanceChanged()
        {
            // Check if anyone has been subscribed to event
            // If no one has subscribed BalanceChanged will be null
            BalanceChanged?.Invoke();
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Available Balance : {Balance}");
        }
        public void Withdraw(double amount)
        {
            if(Balance >= amount )
            {
                Console.WriteLine($"Amount Withdrwan :{amount}");
                Balance -= amount;                              
            }
            else
            {
                Console.WriteLine($"Insufficient Balance");
            }            
        }

        public void Deposit(double amount)
        {
            Console.WriteLine($"Amount deposited :{amount}");
            Balance += amount;                    
        }
    }

    //public class BalanceChangeEvent
    //{
    //    public double Balance { get; set; }
    //}
}
