using System;
using System.Collections.Generic;
using System.Linq;

class Programming : IEquatable<Programming>
{
    public string NameOfLanguage {get;set;}
    public int EffOfLanguage {get;set;}
    public int RelYearOfLanguage {get;set;}
    public bool Equals(Programming other)
    {
        if(object.ReferenceEquals(other, null)) return false;
        if(object.ReferenceEquals(this, other)) return true;
        return EffOfLanguage.Equals(other.EffOfLanguage) && NameOfLanguage.Equals(other.NameOfLanguage);
    }
    public override int GetHashCode()
    {
        int effection = EffOfLanguage.GetHashCode();
        int name = NameOfLanguage.GetHashCode();
        return effection ^ name;
    }
}

class Program
{
    static void Main()
    {
        // List<string> Slist = new List<string>() {"Java", "Python", "Bash", "CSharp", "c"};
        // var isExist = Slist.AsEnumerable().Contains("Java");
        // Console.WriteLine(isExist);

        var ListOfProgram = new List<Programming>()
        {
            new Programming() {NameOfLanguage = "Python", EffOfLanguage = 8, RelYearOfLanguage = 1989},
            new Programming() {NameOfLanguage = "Java", EffOfLanguage = 9, RelYearOfLanguage = 1944},
            new Programming() {NameOfLanguage = "C", EffOfLanguage = 10, RelYearOfLanguage = 1962},
            new Programming() {NameOfLanguage = "C#", EffOfLanguage = 9, RelYearOfLanguage = 1955},
        };

        var MethodSyn = ListOfProgram.Any(e => e.NameOfLanguage == "C");
        Console.WriteLine(MethodSyn);

    }
}
