using System;

public class ProcessingData : EventArgs
{
    public string Name {get;set;}
    public int Id {get;set;}
    public DateTime CompletedTime {get;set;}
}

class Program
{
    public static event EventHandler<ProcessingData> OnProcessingData;
    static void Main() {
        OnProcessingData += Message;
        var args = new ProcessingData
        {
            Name = "Logesh",
            Id = 21,
            CompletedTime = DateTime.Now
        };
        OnProcessingData?.Invoke(typeof(Program), args);
    }

    static void Message(object sender, ProcessingData e)
    {
        Console.WriteLine($"The Name: {e.Name}");
        Console.WriteLine($"The Id: {e.Id}");
        Console.WriteLine($"The Date and Time: {e.CompletedTime}");
    }
}