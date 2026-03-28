using System;
using System.Collections.Generic;
using System.Linq;

class StudentsDetailsOfClass1
{
    public string StuName {get;set;}
    public int StuID {get;set;}
    public string StuMailID {get;set;}
}

class StudentsDetailsOfClass2
{
    public string StuName {get;set;}
    public int StuID {get;set;}
    public string StuMailID {get;set;}
}

class Program
{
    static void Main()
    {
        var ListOfStudents1 = new List<StudentsDetailsOfClass1>()
        {
            new StudentsDetailsOfClass1() {StuName = "Tim", StuID = 1, StuMailID = "tim123@gmail.com"},
            new StudentsDetailsOfClass1() {StuName = "James", StuID = 2, StuMailID = "james1@gmail.com"},
            new StudentsDetailsOfClass1() {StuName = "Pop", StuID = 3, StuMailID = "pop22@gmail.com"},
            new StudentsDetailsOfClass1() {StuName = "Jack", StuID = 4, StuMailID = "jack555@gmail.com"},
            new StudentsDetailsOfClass1() {StuName = "Lucus", StuID = 5, StuMailID = "lucuslucus@gmail.com"},
            new StudentsDetailsOfClass1() {StuName = "William", StuID = 6, StuMailID = "williamwills@gmail.com"},
        };
        var ListOfStudents2 = new List<StudentsDetailsOfClass2>()
        {
            new StudentsDetailsOfClass2() {StuName = "Tim", StuID = 7, StuMailID = "timtim1@gmail.com"},
            new StudentsDetailsOfClass2() {StuName = "James", StuID = 8, StuMailID = "james51@gmail.com"},
            new StudentsDetailsOfClass2() {StuName = "Pop", StuID = 9, StuMailID = "poppop2@gmail.com"},
            new StudentsDetailsOfClass2() {StuName = "Jack", StuID = 10, StuMailID = "jackham@gmail.com"},
            new StudentsDetailsOfClass2() {StuName = "Lucus", StuID = 11, StuMailID = "lucus589@gmail.com"},
            new StudentsDetailsOfClass2() {StuName = "William", StuID =12, StuMailID = "willswill@gmail.com"},
        };

        // var qs = from student in ListOfStudents1
        //          join details in ListOfStudents2
        //          on student.StuName equals details.StuName
        //          select new
        //          {
        //              StudentNameIn1 = student.StuName,
        //              StudentMailIn1 = student.StuMailID,
        //              StudentNameIn2 = details.StuName,
        //              StudentMailin2 = details.StuMailID
        //          };

        var ms = ListOfStudents1.Join(ListOfStudents2,
                                      Name => Name.StuName,
                                      Mail => Mail.StuName,
                                       (Name, Mail)=>new {
                                      NameOfStu = Name.StuName,
                                      Mails1 = Mail.StuMailID,
                                      Mails2 = Name.StuMailID

                                    });
        Console.WriteLine("====Student have similar Names, so We need separate them by their MAIL=====");
        foreach(var item in ms)
        {
            Console.WriteLine($"Mail in Class-1: {item.Mails2} \nMail in Class-2: {item.Mails1}");
        }
    }
}