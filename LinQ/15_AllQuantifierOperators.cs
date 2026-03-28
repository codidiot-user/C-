using System;
using System.Collections.Generic;
using System.Linq;

class Students
{
    public string? Sname {get; set;}
    public int? sID {get; set;}
    public string? subject {get; set;}
    public int? marks {get; set;}
}

class Program
{
    static void Main()
    {
        var data = new List<Students>()
        {
            new Students() {Sname = "lol", sID = 3, subject = "maths", marks = 80 },
            new Students() {Sname = "pap", sID = 2, subject = "mb", marks = 90},
            new Students() {Sname = "sas", sID = 1, subject = "doc", marks = 95}
        };
        var meth = data.All(student => student.marks > 90);
        var query = (from i in data
                    select i).All(e => e.marks >= 80);
        Console.WriteLine(meth);
        Console.WriteLine(query);
    }
}