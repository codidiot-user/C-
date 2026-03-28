using System;
using System.Collections.Generic;
using System.Linq;

class Students
{
    public string NameOfStudent {get; set;}
    public int RollNumberOfStudent {get; set;}
    public List<MarkStatement> MarksOfStudent{get; set;}
}

class MarkStatement
{
    public string SubjectWise {get;set;}
    
}

class Program
{
    static void Main()
    {
       var studensData = new List<Students>()
       {
         new Students()
         {
             NameOfStudent = "Tom",
             RollNumberOfStudent = 2,
             MarksOfStudent = new List<MarkStatement>()
             {
                 new MarkStatement() {SubjectWise = "Phy"}
             }
         },
          new Students()
         {
             NameOfStudent = "Jack",
             RollNumberOfStudent = 4,
             MarksOfStudent = new List<MarkStatement>()
             {
                 new MarkStatement() {SubjectWise = "Che"}
             }
         } ,
          new Students()
         {
             NameOfStudent = "Tim",
             RollNumberOfStudent = 3,
             MarksOfStudent = new List<MarkStatement>()
             {
                 new MarkStatement() {SubjectWise = "Bot"}
             }
         }  
       };
    //    var q = studensData.All(id => id.RollNumberOfStudent > 2);
       var q = studensData.Where(i => i.MarksOfStudent.All(su => su.SubjectWise.Length > 2)).Select(su =>su.NameOfStudent).ToList();
        Console.WriteLine(q);
    //    foreach(var obj in q)
    //     {
    //     }
    }
}