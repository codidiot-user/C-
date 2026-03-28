using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;

class Student1
{
    public string name{get;set;}
    public int sid {get;set;}

}

class Student2
{
    public string name{get;set;}
    public int sid {get;set;}

}
class Program
{
    static void Main()
    {
        var studentDB1 = new List<Student1>()
        {
            new Student1() {name = "Tim", sid = 1},
            new Student1() {name = "Tom", sid = 2},
        };
        var studentDB2 = new List<Student2>()
        {
            new Student2() {name = "Tim", sid = 3},
            new Student2() {name = "Tom", sid = 2},
        };

        var MS = studentDB1.Select(x => x.name).Except(studentDB2.Select(x => x.name));
        foreach(var i in MS)
        {
            Console.WriteLine(i);
        }
    }
}