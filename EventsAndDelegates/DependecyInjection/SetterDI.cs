using System;
using System.Collections.Generic;

public interface IHammer
{
    void Use();
}

class SteelHammer : IHammer
{
    public void Use()
    {
        Console.WriteLine("This is Steel Hammer");
    }
}

class WoodHammer : IHammer
{
    public void Use()
    {
        System.Console.WriteLine("This is wood hammer");
    }
}
public class Builder
{
    public IHammer SteelHammer { get; set; }
    public IHammer WoodHammer { get; set; }
    public void BuildHouse()
    {
        SteelHammer.Use();
        WoodHammer.Use();
        System.Console.WriteLine("The house build successfully!");
    }
}


class Program
{
    static void Main()
    {
        WoodHammer wh = new WoodHammer();
        SteelHammer sh = new SteelHammer();
        Builder builder = new Builder();
        builder.SteelHammer = sh;
        builder.WoodHammer = wh;
        builder.BuildHouse();

    }
}