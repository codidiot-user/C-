using System;
using System.Diagnostics;

class Program
{
    public delegate void Notify();
    public static event Notify OnProceesStatus;
    static void Main()
    {
        OnProceesStatus += Message;
        Process();
    }
    static void Process()
    {
        System.Console.WriteLine("Processing...");
        Thread.Sleep(3000);
        OnProceesStatus?.Invoke();
    }
    static void Message()
    {
        System.Console.WriteLine("Process Completed!");
    }
}