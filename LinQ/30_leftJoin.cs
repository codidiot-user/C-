using System;
using System.Linq;
using System.Collections.Generic;

class StudentsDetails
{
    public int StudentID {get;set;}
    public string StudentName {get;set;}
    public int StudentAdd {get;set;}
}

class AddressOfStudents
{
    public int ID {get;set;}
    public string AdressLine {get;set;}
}


class Program
{
    static void Main()
    {
        var student = new List<StudentsDetails>()
        {
            new StudentsDetails() {StudentID = 1, StudentName = "Tom", StudentAdd = 1},
            new StudentsDetails() {StudentID = 2, StudentName = "Martin", StudentAdd = 2},
            new StudentsDetails() {StudentID = 3, StudentName = "Tim", StudentAdd = 3},
            new StudentsDetails() {StudentID = 4, StudentName = "Apollo", StudentAdd = 4},
            new StudentsDetails() {StudentID = 5, StudentName = "Tommy", StudentAdd = 5},
        };
        var addr = new List<AddressOfStudents>()
        {
            new AddressOfStudents {ID = 1, AdressLine = "Tom Address"},
            new AddressOfStudents {ID = 3, AdressLine = "Tim Address"},
            new AddressOfStudents {ID = 5, AdressLine = "Tommy Address"},
        };
             
        var qs = from std in student
                 join ad in addr on std.StudentAdd equals ad.ID into StdAddr
                 from StudentAddes in StdAddr.DefaultIfEmpty()
                 select new {Name = std.StudentName,
                             Addresss = StudentAddes != null ? StudentAddes.AdressLine : "NA"};
        foreach(var obj in qs)
        {
            Console.WriteLine(obj.Addresss+" "+obj.Name);
        }

    }
}
