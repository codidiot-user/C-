using System;
class Car
{
    private string color;
    public string ChangeColor
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }

}
class Program {
    static void Main (string[]a)
    {
        Car c1 = new Car();
        c1.ChangeColor = "black";
        c1.ChangeColor = "blue";
        Console.WriteLine(c1.ChangeColor);
    }
}

