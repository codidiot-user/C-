using System;
class Logesh
{
    static void Main(string[]log)
    {
        string res = Mymethod("Logesh", 21);
        Console.WriteLine(res);
    }
    static string Mymethod(string name, int age)
    {
        return name+ age;
    }
}    