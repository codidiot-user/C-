using System;
class Program
{
    static void Main (string[]asa)
    {
        try
        {
            int num1 = 1;
            int num2 = 0;
            Console.WriteLine(num1/num2);
        }
        catch (Exception f)
        {
            Console.WriteLine("Something Wrong. "+f);
        }
        finally
        {
            int num1 = 1;
            int num2 = 1;
            Console.WriteLine("This is executing in Finally Block!!!");
            Console.WriteLine(num1+num2);
        }
    }
}