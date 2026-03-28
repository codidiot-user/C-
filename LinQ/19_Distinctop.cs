using System;
using System.Linq;
using System.Collections.Generic;


class Animals
{
    public string NameOfAnimal {get; set;}
    public double SizeOfAnimal {get; set;} 
    public string ClassificationOfAnimal {get; set;}
    public double WeigthOfAnimal {get; set;}
}
class Program
{
    static void Main()
    {
        // var RollNum = new List<int>(){1,2,1,3,2,2,4,5,2,4};
        // var MS = RollNum.Distinct();
        // foreach(var i in MS)
        // {
            // Console.Write(i + " ");
        // }

        // var QS = (from r in RollNum
        //         select r).Distinct();
        // foreach (var item in QS)
        // {
        //     Console.Write(item + " ");
        // }
        var ListOfAnimals = new List<Animals>()
        {
            new Animals() {NameOfAnimal = "Tiger", SizeOfAnimal = 2.50, ClassificationOfAnimal = "Big cats", WeigthOfAnimal = 239.5},
            new Animals() {NameOfAnimal = "Lion", SizeOfAnimal = 3.00, ClassificationOfAnimal = "Big cats", WeigthOfAnimal = 209.5},
            new Animals() {NameOfAnimal = "Deer", SizeOfAnimal = 4.10, ClassificationOfAnimal = "Mammals", WeigthOfAnimal = 159.5},
            new Animals() {NameOfAnimal = "Cat", SizeOfAnimal = 1.5, ClassificationOfAnimal = "Cats", WeigthOfAnimal = 3.8},
            new Animals() {NameOfAnimal = "Tiger", SizeOfAnimal = 2.50, ClassificationOfAnimal = "Big cats", WeigthOfAnimal = 239.5},
            new Animals() {NameOfAnimal = "Dog", SizeOfAnimal = 1.97, ClassificationOfAnimal = "Carnivor", WeigthOfAnimal = 10.15},
        };

        var MS = ListOfAnimals.Select(x => x.ClassificationOfAnimal).Distinct();
        foreach(var a in MS)
        {
            Console.WriteLine(a);
        }
    }
}