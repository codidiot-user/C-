using System;

public class HelloWorld
{
    static void Main (string[]pp) {
        Console.WriteLine("=== Mini Banking System ===");
        
        double balance = 5000;
        bool system = true;
        Console.WriteLine("Your Initial Bank Balance: "+balance);
        while(system) {
        Console.Write("0 for WithDraw, 1 for Depsoit, 9 for quit: ");
        
        int depOrWith = Convert.ToInt32(Console.ReadLine());
        if( depOrWith == 1) {
            Console.Write("Enter amount to Deposit: ");
            double depositAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your total balance after depositment: "+ Deposit(balance, depositAmount));
        } 
        else if( depOrWith == 0) {
            Console.Write("Enter amount to withdraw: ");
            double withdrawAmount = Convert.ToInt32(Console.ReadLine());
            
            if (withdrawAmount > balance) {
                Console.WriteLine("You can't able to with Draw, You are out of balance amount!!!");
            }
            else {
                Console.WriteLine("Your total balance after withdrawing: "+ WithDraw(balance, withdrawAmount));
            }
        } 
        else if(depOrWith == 9)
            {
                system = false;
            }
        else {
            Console.WriteLine("You entered Wrong Entry Number. Do it Again...");
        }
    }
    Console.WriteLine("=== Thank you ===");
    }
    static double Deposit(double balance, double depositAmount) {
        return balance+depositAmount;
    }
    
    static double WithDraw(double balance, double withdrawAmount) {
        return balance - withdrawAmount;
    }
}
