using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

class DetailsOfEmpo
{
    public string NameOfEmpo {get;set;}
    public int IdOfEmpo {get;set;}
    public double WeigthOfEmpo {get;set;}
}

class DetailsToCompare : IEqualityComparer<DetailsOfEmpo>
{
    public bool Equals(DetailsOfEmpo x, DetailsOfEmpo y)
    {
        if (x == null || y == null) return false;
        return x.NameOfEmpo == y.NameOfEmpo && x.IdOfEmpo == y.IdOfEmpo;
    }
    public int GetHashCode(DetailsOfEmpo x)
    {
        if(x == null) return 0;
        return x.NameOfEmpo.GetHashCode() ^ x.IdOfEmpo.GetHashCode();
    }
}



class Program
{
    static void Main()
    {
        var DataSource1 = new List<DetailsOfEmpo>()
        {
          new DetailsOfEmpo() {NameOfEmpo = "Frang", IdOfEmpo = 1, WeigthOfEmpo = 55.2},
          new DetailsOfEmpo() {NameOfEmpo = "Sping", IdOfEmpo = 2, WeigthOfEmpo = 60.1},
          new DetailsOfEmpo() {NameOfEmpo = "Deeksu", IdOfEmpo = 3, WeigthOfEmpo = 65.00}  
        };

        var DataSource2 = new List<DetailsOfEmpo>()
        {
          new DetailsOfEmpo() {NameOfEmpo = "Frang", IdOfEmpo = 4, WeigthOfEmpo = 55.2},
          new DetailsOfEmpo() {NameOfEmpo = "Geeksu", IdOfEmpo = 2, WeigthOfEmpo = 60.1},
          new DetailsOfEmpo() {NameOfEmpo = "Deeksu", IdOfEmpo = 3, WeigthOfEmpo = 65.00}
        };

        var ms = DataSource1.Intersect(DataSource2, new DetailsToCompare());
        foreach(var obj in ms)
        {
            Console.WriteLine($"Name of EMP - {obj.NameOfEmpo} and their id - {obj.IdOfEmpo}");
        }

    }
}

