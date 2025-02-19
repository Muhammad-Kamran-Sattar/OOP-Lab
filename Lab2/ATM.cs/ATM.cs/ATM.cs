using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class ATM
    {

        public double Balance;
        public double Amount;
        public double Deposite;
        public double WithdrawAmount;
        public  List<double> Balances=new List<double>();
        public ATM()
        { }
        public ATM(double balance,double amount, double deposite, double withdrawamount, List<double> balances)
        {
            Balance = balance;
            Amount = amount;
            Deposite = deposite;
            WithdrawAmount = withdrawamount;
            Balances = balances;
            
        }
        public double adddeposite(double Deposite)
        { 
            Balance =Balance +Deposite;
            return Balance;

        }
        public double withdraw(double WithdrawAmount)
        {
            if (Balance > WithdrawAmount)
            {
                Balance = Balance - WithdrawAmount;
                return Balance;
            }
            else 
            {
                Console.WriteLine("Not enough balance in ATM ");
            }
            return Balance;
        }
        public void check()
        {
            
            Console.WriteLine($"Balance in the atm. {Balance}");
        }
        public void transaction_history(List<double> Balances)
        { 
            Balances.Add(Balance);
            Balances.Add(WithdrawAmount);
            Balances.Add(Deposite);
            for (int x = 0; x < Balances.Count; x++)
            {
                if (x == 0)
                {
                    Console.WriteLine($"Balance {Balances[x]}");
                }
                else if (x == 1)
                {
                        Console.WriteLine($"Deposite {Balances[x]}");
                    
                }
                else if (x == 2)
                {
                    Console.WriteLine($"with draw {Balances[x]}");

                }
            }
        }


    } 

    






    

}
