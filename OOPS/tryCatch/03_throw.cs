using System;
class Program
{
    static void Main (string[]asa)
    {
        int age = Convert.ToInt32(Console.ReadLine());
        if(age < 18)
        {
            throw new SomethinWrongExceptionOccured("Access-denied");
        } 
        else
        {
            Console.WriteLine("Opeing...");
        }
    }
}