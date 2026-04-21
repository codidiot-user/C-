using System;
class Program
{
    static void Main()
    {
        ProcessNumber1 (5, PrintSquare);
        ProcessNumber2 (7, PrintinCube);

    }
    static void ProcessNumber1(int num, Action<int> op)
    {
        System.Console.WriteLine("Printing Square...");
        op(num);
    }
    static void PrintSquare(int num)
    {
        System.Console.WriteLine(num*num);
    }
    static void ProcessNumber2(int num, Action<int> op)
    {
        System.Console.WriteLine("Printing Cube...");
        op(num);
    }
    static void PrintinCube(int num)
    {
        System.Console.WriteLine(num*num*num);
    }
}