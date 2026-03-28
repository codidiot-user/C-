using System;
public class WrongPassword : Exception
{
    public WrongPassword(string message) : base(message)
    {
    }
}
public class User
{
    public string password {get; private set;}
    public void Setpass(string input)
    {
        if(string.IsNullOrEmpty(input) || input.Length < 6)
        {
            throw new WrongPassword("You need to set strong password.");
        }
        password = input;
        Console.WriteLine("Success you set a password = "+password);
    }
}
class Program
{
    static void Main (string[] assa)
    {
        User u = new User();
        try
        {
            u.Setpass("123");
        }
        catch (WrongPassword e)
        {
            Console.WriteLine("Access denied: "+e);
        }
    }
}