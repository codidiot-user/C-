using System;
using System.Collections;
class Program
{
    static void Main(string[]asa)
    {
        // int[] arr = new int[10];
        // Console.WriteLine(arr.Length);
        // Array.Resize(ref arr, 15);  // IT WILL DELETE THE ARRAY (WHICH MENTIONED USING 'ref')
        // Console.WriteLine(arr.Length);

        // ArrayList al = new ArrayList();
        // al.Add(1);
        // al.Add(2);
        // al.Insert(2, 3);
        // al.Add(4);
        // al.RemoveAt(2);
        // Console.WriteLine(al.Capacity);
        // foreach (int st in al)
        // {
        //     Console.Write(st + " ");
        // }
        ArrayList al = new ArrayList();
        al.Add(1);
        al.Add("Hello");
        al.Add(3.144);
        foreach (object obj in al)
        {
            Console.Write(obj+" "); 
        }

    }
}