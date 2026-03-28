using System;
class Program
{
    static void Main (string[]asa)
    {
        try
        {
            int[] array = {1,2,3,4};
            Console.WriteLine(array[5]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Something wrong in Array access...");
        }
    }
}