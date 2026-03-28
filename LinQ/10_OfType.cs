using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        var ListOfEmpolyees = new List<object>()
        {
            "Tim", "Tom", "Jack", "Tiger","Maniya", 1, 2, 3, 4
        };
        var emp = ListOfEmpolyees.OfType<string>().Where(x => x.Length > 3);
        foreach(var i in emp)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Executing Query Syntax: ");
       
        var emp1 = from e in ListOfEmpolyees
                    where e is int
                    let iVal = (int) e
                    where iVal > 2
                    select iVal;
        foreach(var ii in emp1)
        {
            Console.WriteLine(ii);
        }

        }
}