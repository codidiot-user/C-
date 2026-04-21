using System;

class Program
{
    static void Main()
    {
        Func<int, int, int> operation = Add;
        System.Console.WriteLine(operation(1,2));
    }
    static int Add(int a, int b)
    {
        return a+b;
    }
}