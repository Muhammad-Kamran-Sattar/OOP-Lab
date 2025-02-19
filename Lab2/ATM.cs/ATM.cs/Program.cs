using System.ComponentModel.Design;
using Atm;

public class Program
{
    public static void menu()
    {
        Console.WriteLine($"1.Deposite amount");
        Console.WriteLine($"2.With draw amount");
        Console.WriteLine($"3.Check balance");
        Console.WriteLine($"4.Transaction history");
        Console.WriteLine($"Your option...... ");
    }
    public static void Main(string[] args)
    {
        int option;
        double balance =1000;
        double amount=0;
        double deposite=0;
        double withdrawamount=0; 
        List< double > balances =new List<double> ();



        ATM atm = new ATM(balance,amount,deposite,withdrawamount,balances);
        double x = 0;
        while (true)
        {

            menu();
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Enter the amount you want to deposite.");
                deposite = Convert.ToInt32(Console.ReadLine());
                x = atm.adddeposite(deposite);
                balances.Add(x);
                Console.ReadKey();
                Console.Clear();
                option = 0;

                //Console.WriteLine(x);
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter the amount you want to with draw.");
                withdrawamount = Convert.ToInt32(Console.ReadLine());
                x = atm.withdraw(withdrawamount);
                Console.WriteLine(x);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                option = 0;
            }
            else if (option == 3)
            {
                atm.check();
                
                ;
                Console.ReadKey();
                Console.Clear();
                option = 0;
            }
            else if (option == 4)
            {
                atm.transaction_history(balances);
                Console.ReadKey();
                Console.Clear();
                option = 0;
            }

        }

    }



}
