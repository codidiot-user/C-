using System;
using System.Collections.Generic;
using System.Linq;

class College
{
    public int StaffIDNum {get;set;}
    public string StaffName {get;set;} 

}

class DepartmentWiseStaff
{
    public int StaffIDNum {get;set;}
    public int NoOfSubjectHandling {get;set;}
    public int NumOfStudentsStudying {get;set;}
}

class SalarayOfStaff
{
    public int StaffIDNum{get;set;}
    public double StaffSalary {get;set;}

}

class Program
{
    static void Main()
    {
        var college = new List<College>()
        {
            new College() {StaffIDNum = 1, StaffName = "James"},
            new College() {StaffIDNum = 2, StaffName = "Steve"},
            new College() {StaffIDNum = 3, StaffName = "Berlin"},
            new College() {StaffIDNum = 4, StaffName = "Professor"},
            new College() {StaffIDNum = 5, StaffName = "Tokyo"},
            new College() {StaffIDNum = 6, StaffName = "Suku"},
            new College() {StaffIDNum = 7, StaffName = "Harry"},
            new College() {StaffIDNum = 8, StaffName = "Nands"},
            new College() {StaffIDNum = 9, StaffName = "Govins"},
            new College() {StaffIDNum = 10, StaffName = "Jacky"}
        };

        var deptStaff = new List<DepartmentWiseStaff>()
        {
            new DepartmentWiseStaff() {StaffIDNum = 1, NoOfSubjectHandling = 2, NumOfStudentsStudying = 150},
            new DepartmentWiseStaff() {StaffIDNum = 9, NoOfSubjectHandling = 1, NumOfStudentsStudying = 100},
            new DepartmentWiseStaff() {StaffIDNum = 3, NoOfSubjectHandling = 3, NumOfStudentsStudying = 120},
            new DepartmentWiseStaff() {StaffIDNum = 7, NoOfSubjectHandling = 0, NumOfStudentsStudying = 0},
            new DepartmentWiseStaff() {StaffIDNum = 5, NoOfSubjectHandling = 2, NumOfStudentsStudying = 130},
        };
        
        var Salary = new List<SalarayOfStaff>()
        {
            new SalarayOfStaff() {StaffIDNum = 1, StaffSalary = 2000.15},
            new SalarayOfStaff() {StaffIDNum = 9, StaffSalary = 3500.98},
            new SalarayOfStaff() {StaffIDNum = 3, StaffSalary = 2900.65}
        };

        var qs = from NameOfStaff in college
                join StaffOfDept in deptStaff
                on NameOfStaff.StaffIDNum equals StaffOfDept.StaffIDNum
                join StaffSalary in Salary
                on NameOfStaff.StaffIDNum equals StaffSalary.StaffIDNum
                select new
                {
                  StaffN = NameOfStaff.StaffName,
                  FullSalary = StaffSalary.StaffSalary  
                };
        foreach(var item in qs)
        {
            Console.WriteLine($"Name of Staff: {item.StaffN} and their Salary: {item.FullSalary}");
        }
}
}


