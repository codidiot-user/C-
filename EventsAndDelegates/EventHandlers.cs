using System;

class Program
{
    public static event EventHandler OnProcessing;
    static void Main()
    {
        OnProcessing += Message;
        Process();
    }

    static void Process()
    {
        System.Console.WriteLine("Processing...");
        OnProcessing?.Invoke("My Data", EventArgs.Empty);
        
    }
    
    static void Message(object sender, EventArgs e)
    {
        Console.WriteLine($"This sender: {sender}");
        Console.WriteLine($"This Event Args: {sender?.GetType()}");
    }
}
