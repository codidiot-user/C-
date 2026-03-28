using System;
class Logesh
{
    static void Main (string[]s)
    {
        string rr = Mymethod("logesh");
        string r = Mymethod();
        int a = Mymethod(21);
        Console.WriteLine(r+rr+a);
    }
    static string Mymethod(string n = "Mano")
    {
        return n;
    }
    static int Mymethod(int a)
    {
        return a;
    }
}