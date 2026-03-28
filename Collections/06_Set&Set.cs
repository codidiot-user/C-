using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList all = new ArrayList();
        all.Add(1); all.Add(2); all.Add(3);all.Add(4);all.Add(5);
        foreach(object obj in all)
        {
            Console.Write(obj + " ");
        }
        Console.WriteLine();
        try {
        all[8] = 666;
        foreach(object obj in all)
        {
            Console.Write(obj + " ");
        }
        }
        catch (Exception e) {
        Console.WriteLine(e.Message);
        }
    }
}