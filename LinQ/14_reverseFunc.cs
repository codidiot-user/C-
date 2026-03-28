using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var roll = new List<int>() {1,2,9,3,4,5,8,6,7};
        foreach(var i in roll)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("========");
        var reverslist = roll.AsQueryable().Reverse();
        foreach(var objj in reverslist)
        {
            Console.Write(objj+" ");
        }
        Console.WriteLine();
        Console.WriteLine("========");
        var method = roll.OrderBy(emp => emp);
        foreach(var obj in method)
        {
            Console.Write(obj+ " ");
        }
        Console.WriteLine();
        Console.WriteLine("========");
        var rev = method.Reverse();
        foreach(var o in rev)
        {
            Console.Write(o+" ");
        }
    }
}