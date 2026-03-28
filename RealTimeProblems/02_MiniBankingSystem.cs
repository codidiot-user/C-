using System;
// using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Transactions;

public class InvalidPasswordDetected : Exception
{
    public InvalidPasswordDetected(string message) : base(message)
    {
        
    }
}

class User
{
    public string Password {get; private set;} 
    public void SetPass(string value)
    {
        if(!ValidPassChecking(value)) throw new InvalidPasswordDetected ("Access to denied to get to your account!");
        Password = value;
        Console.WriteLine("The user password: " + Password);
    }
    private bool ValidPassChecking(string str)
    {
        if(str.Length < 8 || str.Length > 15 || string.IsNullOrEmpty(str)) return false;
        if(str.Equals("Password@123", StringComparison.OrdinalIgnoreCase)) return false;
        bool upper = false, lower = false, digit = false, special = false;
        for(int i=0;i<str.Length;i++)
        {
            char ch = str[i];
            if(char.IsUpper(ch)) upper = true;
            if(char.IsLower(ch)) lower= true;
            if(char.IsDigit(ch)) digit = true;
            if(!char.IsLetterOrDigit(ch)) special = true;
            if (upper && lower && digit && special) return true;
        }
        return false;
    }
}

class BankActivity
{
    private double AccountBalance = 50000;
    
    // Console.WriteLine();
    public double Balance => AccountBalance;
    private string transFile = @"D:\HCL\RealTimeProblems\transcation.txt";
    public void WithDraw(double amount)
    {
        if(amount > AccountBalance)
        {
            Console.WriteLine("Insufficient withdraw amount, your account balance is = "+AccountBalance);
            return;
        }
        if( amount <= 0)
        {
            Console.WriteLine("Invalid WithDraw amount!");
            
        }
        else
        {
            AccountBalance -= amount;
            Console.WriteLine($"Your withdraw amount is {amount} and the remaining balance in your account {AccountBalance}");
            string record = $"WITHDRAWAL: {amount} | New Balance: {AccountBalance}\n";
            File.AppendAllText(transFile, record);
        }
    }
    public void Deposit (double amount)
    {
        if (amount <= 0 )
        {
            Console.WriteLine("Not able to deposit = " + amount);
        }
        else
        {
            AccountBalance += amount;
            Console.WriteLine ($"Your account balance after deposit of {AccountBalance} and the deposit amount is {amount}");
            string record = $"DEPOSIT: {amount} | New Balance: {AccountBalance}\n";
            File.AppendAllText(transFile, record);
        }
    }
}

class Program
{
    static void Main (string[]assa)
    {
        User u = new User();
        BankActivity b = new BankActivity();
        Console.WriteLine("=== MINI BANKING SYSTEM ===");
        Console.Write("Enter your account password to get in: ");
        string pass = Console.ReadLine();
        Console.WriteLine($"You balance is: {b.Balance}");
        Console.WriteLine("----------------------------");
        try
        {
            bool system = true;
            u.SetPass(pass);
            while (system) {
                Console.Write("Enter 0 for WithDraw, 1 for Deposit, 9 to Quit: ");
                int pin = Convert.ToInt32(Console.ReadLine());
            if (pin == 1)
            {
                Console.Write("Enter amount to deposit: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                b.Deposit(amount);
            }
            else if (pin == 0)
            {
                Console.Write("Enter amount to WithDraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                b.WithDraw(amount);
            }
           else if (pin == 9)
                {
                    system = false;
                }
            else
            {
                Console.WriteLine ("Invalid option!");
            }
        } 
            Console.WriteLine("=== Thank You ===");
        }
        catch (InvalidPasswordDetected e)
        {
            Console.WriteLine("Wrong Password: " + e.Message);
        }
    }
}