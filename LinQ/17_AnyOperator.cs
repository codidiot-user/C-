using System;
using System.Collections.Generic;
using System.Linq;

class Animals
{
    public string NameAnimal {get; set;}
    public int animalNumber {get; set;}
    public double lengthOfAnimal {get; set;}
}

class Program
{
    static void Main()
    {
        var dataOfAnimal = new List<Animals>()
        {
            new Animals() {NameAnimal = "Tiger", animalNumber = 1, lengthOfAnimal = 5.15},
            new Animals() {NameAnimal = "Lion", animalNumber = 4, lengthOfAnimal = 6.02},
            new Animals() {NameAnimal = "goat", animalNumber = 1, lengthOfAnimal = 4.5},
            new Animals() {NameAnimal = "Bear", animalNumber = 2, lengthOfAnimal = 6.75},
        };
        var ms = dataOfAnimal.Any(ani => ani.lengthOfAnimal > 7.15);
        // Console.WriteLine(ms);
        var qs = (from i in dataOfAnimal
                select i).Any(e => e.NameAnimal.Length > 4);
        Console.WriteLine(qs);

    }
}