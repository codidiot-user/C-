using System;
class Person
{
    public string name;
    public int id;
    public Person(string name, int id)
    {
        this.name = name;
        this.id = id;
        Console.WriteLine($"The name: {name}");
    }
}

class Empolyee : Person
{
    public int id;
    public Empolyee(string name, int id) : base(name, id)
    {
        
        Console.WriteLine($"The id is: {name} {id}");
    }
}

class Program
{
    static void Main (string[]asa)
    {
        Empolyee e = new Empolyee("Log",21);
        // Console.WriteLine(e.name);
    }
}