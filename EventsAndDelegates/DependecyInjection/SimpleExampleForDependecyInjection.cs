using System;
using System.Collections.Generic;

public interface IHammer
{
    void Use();
}

class WoodHammer : IHammer
{
    public void Use()
    {
        System.Console.WriteLine("This is Wood Hammer.");
    }
}
class SteelHammer : IHammer
{
    public void Use()
    {
        System.Console.WriteLine("This is Steel Hammer.");
    }
}
class RubberHammer : IHammer
{
    public void Use()
    {
        System.Console.WriteLine("This is Rubber Hammer.");
    }
}

public class Builder
{
    private IHammer _hammer;
    public Builder(IHammer hammer)
    {
        _hammer = hammer;
    }
    public void BuilderHouse()
    {
        _hammer.Use();
        System.Console.WriteLine("This house has build using different hammer.");
    }
}

class Program
{
    static void Main()
    {
        WoodHammer woodHammer = new WoodHammer();
        SteelHammer steelHammer = new SteelHammer();
        RubberHammer rubberHammer = new RubberHammer();
        Builder builder = new Builder(woodHammer);
        Builder builder2 = new Builder(steelHammer);
        Builder builder3 = new Builder(rubberHammer);
        builder.BuilderHouse();
        builder2.BuilderHouse();
        builder3.BuilderHouse();
    }
}