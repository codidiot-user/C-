using System;

public class ProcesssingData : EventArgs
{
    public string Name{get;set;}
    public int Id {get;set;}
    public DateTime TimeOfCompletion {get;set;}
}

class Program
{
    public static event EventHandler<ProcesssingData> OnModelProcessingData;
     static void Main()
    {
        OnModelProcessingData += Message;
        var args = new ProcesssingData
        {
            Name = "Logesh",
            Id = 21,
            TimeOfCompletion = DateTime.Now
        };
        OnModelProcessingData?.Invoke(typeof(Program), args);
    }
    static void Message(object sen, ProcesssingData e)
    {
        System.Console.WriteLine($"The name is: {sen?.GetType().Name}");
        System.Console.WriteLine($"This is the name: {e.Name}");
    }
}