using System;
namespace First
{
    class Second
    {
        static void Main (string[]djid)
        {
            int num = 3;
            double myDouble = 3.144;
            // Console.WriteLine(num);
            // Console.WriteLine(myDouble);
            double dd = 2.22;
            int myInt = (int) dd;
            // Console.WriteLine(myInt);
            string str = Convert.ToString(num);
            string str1 =  myDouble.ToString();
            Console.WriteLine(str1); 
            Console.WriteLine(Convert.ToString(dd));
        }
    }
}