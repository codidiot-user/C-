using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList al = new ArrayList();
        al.Add(1);
        al.Add(2); al.Add(3);
        if(al.IsSynchronized)
        {
            Console.WriteLine("Syn");
        }
        else
        {
            Console.WriteLine("Not sync");
        }
        ArrayList AL = ArrayList.Synchronized(al);
        if(AL.IsSynchronized)
        {
            Console.WriteLine("Syn");
        }
        else
        {
            Console.WriteLine("Not");
        }
        // Console.WriteLine( al.IsSynchronized ?  "Synchronized" : "Not Synchronized");

    }
}