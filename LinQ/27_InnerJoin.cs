using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string StudentName {get;set;}
    public int StudentID {get;set;}
    public int AddressID {get;set;}
}

class Address
{
    public int ID {get;set;}
    public string AddressLine {get;set;}
}
class Program
{
    static void Main()
    {
       
        var students = new List<Student>()
        {
            new Student() {StudentName = "Mike", StudentID = 1, AddressID = 1234},
            new Student() {StudentName = "Lucus", StudentID = 2, AddressID = 5678},
            new Student() {StudentName = "El", StudentID = 3, AddressID = 9876},
            new Student() {StudentName = "Will", StudentID = 4, AddressID = 1456},
            new Student() {StudentName = "Dustin", StudentID = 5, AddressID = 9663}
        };
        var adressLine = new List<Address>()
        {
            new Address() {ID = 1, AddressLine = "LOC"},
            new Address() {ID = 22, AddressLine = "POK"},
            new Address() {ID = 3, AddressLine = "SOK"},
            new Address() {ID = 44, AddressLine = "PSS"},
            new Address() {ID = 5, AddressLine = "LSS"}
        };
        var newObj = (from stu in students
                    join ad in adressLine
                    on stu.StudentID equals ad.ID
                    select new
                    {
                        StudenName = stu.StudentName,
                        AddRess = ad.AddressLine,
                        ID = stu.StudentID
                    }).ToList();
        foreach(var obj in newObj)
        {
            Console.WriteLine(obj.StudenName);
        } 

        // var ms = students.Join(adressLine,
        //                        stu => stu.StudentID,
        //                        addr => addr.ID,
        //                        (stu, addr) => new
        //                        {
        //                            Sname = stu.StudentName,
        //                            StudentID = addr.ID
        //                        });
        // foreach(var obj in ms)
        // {
        //     Console.WriteLine($"{obj.Sname} and Address: {obj.StudentID}");
        // }
    } 
}
