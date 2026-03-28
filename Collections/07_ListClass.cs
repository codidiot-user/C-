using System;
using System.Collections.Generic;

class User
{
    public string Name {get; set;}
    public int accountNumber {get; set;}
    public User(string Name, int accountNumber)
    {
        this.Name = Name;
        this.accountNumber = accountNumber;
    }
    public override string ToString()
    {
        return $"The userName {Name}, {accountNumber}.. ";
    }
}

class Program
{
    static void Main(string[]asa)
    {
        List<User> ls = new List<User>();
        ls.Add(new User("LoL", 21));
        ls.Add(new User("LoL", 21));
        ls.Add(new User("LoL", 21));
        foreach(User u in ls)
        {
            Console.Write(u);
        }
    }
}