using System;
using System.Collections.Generic;
class Program
{
    static void Main (string[]asa)
    {
        // List<int> ls = new List<int>() {1,2,3,4,5,6,7,8,9,10};



    ////  ====================== SORTING LIST ===========================

        // List<int> ls = new List<int>() {2,1,4,3,7,4,8};
        // Console.WriteLine("Provided list: ");
        // ls.ForEach(obj => Console.Write(obj+" ")); Console.WriteLine();
        // ls.Sort();
        // Console.WriteLine("Sorted: ");
        // ls.ForEach(obj => Console.Write(obj+" "));

    // // ========================== END OF SORTING LIST ===================

    //// =============== Searching ====================
    
         List<int> ls = new List<int> {1,2,4,3};
         bool contain = ls.Contains(3);
         Console.WriteLine($"Contains or not: {contain}");

    //// ============= LOCATING ========
    
         Console.WriteLine($"The index position is: {ls.IndexOf(2)}");

    ////  ========= INSERTING ===============
    
          ls.Insert(4,5);
          ls.ForEach(obj => Console.Write(obj+" ")); Console.WriteLine();  

    //// ===== BULK ADDING =========
    
         List<int> newLs = new List<int>{6,7,8,9,0};
         ls.AddRange(newLs);
         ls.ForEach(obj => Console.Write(obj+" "));
         
    //// ==========================================================


    // // ======================= DIFFERENT WAYS TO INITIALSE THE LIST ELEMENT ==================
    //     Console.WriteLine("Initial length: "+ls.Count);
    //     List<int> lls = new List<int> (ls);
    //     Console.WriteLine("Enumerable type: ");
    //     foreach(var obj in lls)
    //     {
    //         Console.WriteLine(obj);
    //     }
    //     List<int> l = new List<int>(3);
    //     l.Add(1);l.Add(2);l.Add(4);l.Add(8);
    //     Console.WriteLine("Int 32 size: ");
    //     l.ForEach(obj => Console.WriteLine(obj));  // === FOREACH LOOP IN DIFFERENT APPROACH TO PRINT IT ==========
    // // =================== END OF THE INITIALSE ELEMENT ================================

    
    //// ============ START OF REMOVE METHOD ======================
    
    //    ls.Remove(3);
    //     Console.WriteLine($"Removing element 3 using 'Remove': {ls.Count}");
    //     ls.RemoveAt(3);
    //     Console.WriteLine($"Removing element at index 3 using 'RemoveAt': {ls.Count} ");
    //     ls.RemoveRange(3,4);
    //     Console.WriteLine($"Removing element from to to using 'RemoveRange(index pos, count(how many number need to remove)): {ls.Count}");
    //     ls.Clear();
    //     Console.WriteLine($"Removing all element: {ls.Count}");

    //// ============== END OF REMOVE METHODS =================
    


    }
}