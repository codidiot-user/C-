using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        List<int> ls = new List<int>(num);
        Console.WriteLine("Enter the list element: ");
        for (int i=0; i<num; i++)
        {
            ls.Add(Convert.ToInt32(Console.ReadLine()));
        }
        var querySyn = from ind in ls 
                    where ind > 3
                    select ind;
        
        Console.WriteLine("Query Syntax");
        foreach(var ind in querySyn)
        {
            Console.WriteLine(ind);
        }
        Console.WriteLine("Method Syntax");
        var methodSyn = ls.Where(obj => obj > 2).ToList();

        foreach(var ind in methodSyn)
        {
            Console.WriteLine(ind);
        }
        Console.WriteLine("Mixed Syntax");
        var mixedSyn  = (from obj in ls 
                         select obj).Where(x => x > 2).ToList();
        mixedSyn.ForEach(x => Console.WriteLine(x));
    }
}