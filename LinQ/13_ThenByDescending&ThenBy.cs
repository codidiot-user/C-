using System;
using System.Collections.Generic;
using System.Linq;

class Empolyees
{
    public int Id {get; set;}
    public string FirstEname {get; set;}
    public string LastEname {get; set;}
}

class Program
{
    static void Main()
    {
        var DataSource = new List<Empolyees>()
        {
            new Empolyees()
            {
                Id = 3,
                LastEname = "Mark",
                FirstEname = "Tim",

            },
            new Empolyees()
            {
                Id = 1,
                LastEname = "Max",
                FirstEname = "Tim",
                
            },
            new Empolyees()
            {
                Id = 2,
                LastEname = "Jerry",
                FirstEname = "Tom",
                
            }
        };
        var ms = DataSource.OrderBy(emp => emp.FirstEname).ThenBy(emp =>emp.LastEname);
        foreach(var i in ms)
        {
            // Console.Write(i.FirstEname+" "+ i.LastEname);
        }

        var qs = from i in DataSource
                 orderby i.LastEname , i.LastEname 
                 select i;
        foreach(var m in qs)
        {
            Console.Write(m.FirstEname+""+m.LastEname+" ");
        }
    }
}