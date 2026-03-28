using System;
using System.Collections;
using System.Security.Cryptography;
class Program
{
    static void Main()
    {
        Hashtable hs = new Hashtable();
        hs.Add("Id", 21);
        hs.Add("Amount", 5000);
        hs.Add("balance", 12.5);
        Console.WriteLine("Id".GetHashCode());
        Console.WriteLine(hs.ToString);
        foreach(object obj in hs.Keys)
        {
            Console.WriteLine(obj);
        }
        foreach(object obj in hs.Keys)
        {
            Console.WriteLine(obj + ":" + hs[obj]);
        }
    }
}
