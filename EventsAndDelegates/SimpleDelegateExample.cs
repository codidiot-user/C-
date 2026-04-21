using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

// class Program
// {
//     public delegate void MyDelegate(int x);

//     static void Method1(int num)
//     {
//         Console.WriteLine($"This is printing {num}");
//     }
//     static void Method2(MyDelegate a)
//     {
//         System.Console.WriteLine("Loading...");
//         Thread.Sleep(3000);
//         a(10); 
//     }

//     static void Main()
//     {
//         Method2(Method1); 
//     }
// }


class Program
{
    public delegate int Mydel(int a, int b);
    static int Add(int a, int b) => a+b;
    static int Multiply(int a, int b) => a*b;
    static void Method1(int a, int b, Mydel op)
    {
        int res = op(a,b);
        Console.WriteLine("Result: "+res);
    }
    static void Main()
    {
        Method1(2, 3, Add);
        Method1(3, 4, Multiply);
    }
}


