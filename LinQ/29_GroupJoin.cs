using System;
using System.Collections.Generic;
using System.Linq;


class StudentsData
{
    public int SerialNumber {get;set;}
    public string StudentName {get;set;}
    public int CategoryID {get;set;}
}
class Category
{
    public int ID {get;set;}
    public double Percentage {get;set;}
}



class Program
{
    static void Main()
    {
        var student = new List<StudentsData>()
        {
            new StudentsData() {SerialNumber = 1, StudentName = "Tim", CategoryID = 1},
            new StudentsData() {SerialNumber = 2, StudentName = "Jack", CategoryID = 1},
            new StudentsData() {SerialNumber = 3, StudentName = "Pop", CategoryID = 2},
            new StudentsData() {SerialNumber = 4, StudentName = "Tisson", CategoryID = 2},
            new StudentsData() {SerialNumber = 5, StudentName = "Taro", CategoryID = 3},
            new StudentsData() {SerialNumber = 6, StudentName = "Kim", CategoryID = 4},
            new StudentsData() {SerialNumber = 7, StudentName = "Lo", CategoryID = 4},
        };
        var categoryStatus = new List<Category>()
        {
            new Category() {ID = 1, Percentage = 1.2},
            new Category() {ID = 1, Percentage = 2.11},
            new Category() {ID = 3, Percentage = 2.3},
            new Category() {ID = 4, Percentage = 5.2},
            new Category() {ID = 4, Percentage = 1.99},
            new Category() {ID = 5, Percentage = 6.55},
        };
        var ms = categoryStatus.GroupJoin(student, 
                                           outer1 => outer1.ID,
                                           inner1 => inner1.CategoryID,
                                           (outer1, inner1) => new {outer1, inner1});

        // foreach (var item in ms)
        //     {
        //         Console.WriteLine($"Category ID: {item.outer1.ID}, Percentage: {item.outer1.Percentage}");
        //             foreach (var obj in item.inner1)
        //                 {
        //                     Console.WriteLine($"   Student: {obj.StudentName}, Serial: {obj.SerialNumber}");
        //                 }
        //     }
        var qs = from c in categoryStatus
                 join stu in student on c.ID equals stu.CategoryID into stuData
                 select new {c, stuData};
        
        foreach (var item in qs) {
                Console.WriteLine(item.c.Percentage);
                foreach(var obj in item.stuData)
            {
                Console.WriteLine(obj.StudentName);
            }
        }
        
    }
}

