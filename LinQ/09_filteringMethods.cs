//// where && OfTYpe are the two types of methods we used for filtering data from datasource

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

class Empolyees
{
    public int ID {get; set;}
    public string EmpName {get; set;}
    public string mailId {get; set;}
    public List<Tech> Programming {get; set;}
}

class Tech
{
    public string Technology {get; set;}
}

class Program
{
    static void Main()
    {
        var datasource = new List<Empolyees>()
        {
            new Empolyees() {ID = 1, EmpName = "tim", mailId = "tim@gmail.com", Programming = 
            new List<Tech>
            {
                new Tech() {Technology = "Python"},
                new Tech() {Technology = "Java"}
            }
            },
            new Empolyees() {ID = 2, EmpName = "tom", mailId = "tom@gmail.com", Programming = 
            new List<Tech>
            {
                new Tech() {Technology = "C#"},
                new Tech() {Technology = ".NET"}
            }
            },
            new Empolyees() {ID = 3, EmpName = "Jack", mailId = "tjack@gmail.com", Programming = 
            new List<Tech>
            {
                
                new Tech() {Technology = "C++"}
            }
            },
            new Empolyees() {ID = 4, EmpName = "tiger", mailId = "tiger@gmail.com", Programming = 
            new List<Tech>
            {
            }
            },
            
        }.ToList();
        var emp = from i in datasource
                   where i.Programming.Count == 0 && i.ID == 2
                   select i;
        foreach(var obj in emp)
        {
            Console.WriteLine(obj.EmpName);
        }
        var emp1 = datasource.Where(emp => emp.Programming.Count == 2 && emp.ID == 5);
        foreach(var i in emp1)
        {
            Console.WriteLine(i.EmpName);
        }
    }
}