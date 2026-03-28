/*   PAGING IS PROCESS OF DIVIDING N NUMBER OF DATA/RECORDS INTO MULTIPLE PAGES CALLED PAGING.
PAGING CAN BE IMPLEMENTED USING LinQ
WITH THE HELP OF LinQ, WE CAN TAKE 'SKIP', 'TAKE' METHODS. 
HOW:
TOTAL PAGES = T
NUMBER OF RECORDS PER PAGE = N
FORMULA:
   for index => skip(index * n)  take(n)
   for pages =. skip((pagenumber-1)* n) take(n)
*/

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        do {
            int TotalPages = 3;
            if(int.TryParse(Console.ReadLine(), out int Pages))
        {
            if(Pages == -1)
            {
                return; 
            }
            var ms = GetEmpolyeess().Skip((Pages-1) * TotalPages).Take(TotalPages);
            foreach(var obj in ms)
            {
                Console.WriteLine($"{obj.Name} and ID: {obj.ID}");
            }
        } 
        
        else
        {
            Console.WriteLine("Enter a valid Number");
        }
        }
        while(true);
    }
    public static List<Empolyees> GetEmpolyeess()
    {
        return new List<Empolyees>{
        new Empolyees() {ID = 1, Name = "Tim"},
        new Empolyees() {ID = 2, Name = "Tom"},
        new Empolyees() {ID = 3, Name = "Jack"},
        new Empolyees() {ID = 4, Name = "Sparrow"},
        new Empolyees() {ID = 5, Name = "Louis"},
        new Empolyees() {ID = 6, Name = "Mark"},
        new Empolyees() {ID = 7, Name = "Tiger"},
        new Empolyees() {ID = 8, Name = "Maniya"},
        new Empolyees() {ID = 9, Name = "King"},
        new Empolyees() {ID = 10, Name = "Peter"},
        new Empolyees() {ID = 11, Name = "Patrik"},
        new Empolyees() {ID = 12, Name = "John"},
        new Empolyees() {ID = 13, Name = "Martin"},
        new Empolyees() {ID = 14, Name = "Wheeler"},
        new Empolyees() {ID = 15, Name = "James"},
        new Empolyees() {ID = 16, Name = "Hook"}

    };
    }
}

class Empolyees
{
    public int ID {get;set;}
    public string Name {get;set;}
}


