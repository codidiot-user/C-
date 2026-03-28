using System;
using System.Runtime.CompilerServices;
class Man
{
    static void Main (string[]s)
    {
        int num1 = Logesh(1, 2);
        double num2 = Logesh(1.1, 2.2);
        Console.WriteLine(Logesh(1, 2));
    }
    static int Logesh(int x, int y)
    {
        return x+y;
    }
    static double Logesh(double x, double y)
    {
        return x+y;
    }
}