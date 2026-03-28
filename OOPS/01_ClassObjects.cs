using System;
class Logesh
{
    static void Main (string[]pp)
    {
        MyFirstObj myObj = new MyFirstObj("Dark");
        Console.WriteLine(myObj.color);
    }
}
class MyFirstObj
{
    public string color;
   public MyFirstObj(string color)
    {
        this.color = color;
    }
}