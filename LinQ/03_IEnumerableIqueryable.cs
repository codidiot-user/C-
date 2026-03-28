using System.Collections.Generic;
using System.Linq;
using System;

class Empolyee
{
    public string Name {get; set;}
    public int id {get; set;}
}
class Empolyeess
{
    public string name {get; set;}
    public int id {get; set;}
}
class Program
{
    static void Main()
    {
        var ls = new List<Empolyee>()
        {
            
            new Empolyee() {id = 1, Name = "LoL"},
            new Empolyee() {id = 2, Name = "SaS"},
            new Empolyee() {id = 3, Name = "PaP"},
            
        };
        var QuerySync = from obj in ls where obj.id == 1 select obj;
        Console.WriteLine("Query Syntax");
        foreach(var empolyee1 in QuerySync)
        {
            Console.WriteLine($"Empolyee is {empolyee1.id} and Name: {empolyee1.Name}");
        }
        Console.WriteLine("Method Syntax");
        var Methodsync = ls.Where(obj => obj.id == 2);
        foreach(var empolyee2 in Methodsync )
        {
            Console.WriteLine($"The id = {empolyee2.id} and the name = {empolyee2.Name}");
        }
        Console.WriteLine("Mixed Method");
        var MixedSync = (from i in ls select i).Where(o => o.id == 3);
        foreach(var empolyee3 in MixedSync)
        {
            Console.WriteLine($"The id = {empolyee3.id} and the user name = {empolyee3.Name}");
        }
    }
    // static void Main()
    // {
    //     // IQueryAble type
    //     var ls= new List<Empolyeess>()
    //     {
    //         new Empolyeess() {id = 1, name = "Mano"},
    //         new Empolyeess() {id = 2, name = "Darshik"}
    //     };
    //     Console.WriteLine("I QUERYABLE TYPE");
    //     var Methodsync = ls.AsQueryable().Where(empolyee1 => empolyee1.id == 1);
    //     foreach(var ind in Methodsync)
    //     {
    //         Console.WriteLine($"Id = {ind.id} and name = {ind.name}");
    //     }
    // }
}