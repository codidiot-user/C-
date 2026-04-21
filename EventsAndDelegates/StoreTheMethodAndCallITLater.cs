using System;

class Program
{
    static void GreetHello()
    {
        Console.WriteLine("Hello!!!");
    }
    static void GreetGoodBye()
    {
        Console.WriteLine("Good Bye!!!");
    }
    static void Main()
    {
        Action whatToDo = GreetHello;
        whatToDo();
        whatToDo = GreetGoodBye;
        whatToDo();
    }
    
}