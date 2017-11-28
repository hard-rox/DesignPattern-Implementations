using System;

public interface IClonable
{
    IClonable Clone();
}

public abstract class Shape:IClonable
{
    private int Id;
    public abstract void Draw();

    public int GetId()
    {
        return Id;
    }
    public void SetId(int id)
    {
        Id=id;
    }
    public IClonable Clone()
    {
        //shallow copy
        return (IClonable) this.MemberwiseClone();

        //deep copy
        //return (IClonable) this.Clone();
    }
}

public class Ractangle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Ractangle.");
    }
}

public class Triangle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Triangle.");
    }
}

public class Square:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Square.");
    }
}

public class ShapeCache
{
    Ractangle RactangleInstance=new Ractangle();
    Triangle TriangleInstance=new Triangle();
    Square SquareInstance=new Square();

    public Ractangle GetRactangleInstance()
    {
        return (Ractangle) RactangleInstance.Clone();
    }

    public Triangle GetTriangleInstance()
    {
        return (Triangle) TriangleInstance.Clone();
    }

    public Square GetSquareInstance()
    {
        return (Square) SquareInstance.Clone();
    }
}

public class MainClass
{
    public static void Main()
    {
        ShapeCache shapeCache=new ShapeCache();

        Triangle t=shapeCache.GetTriangleInstance();
        t.SetId(1);
        Triangle t2=shapeCache.GetTriangleInstance();

        t2.SetId(3);
        
        t.Draw();
        Console.WriteLine(t.GetId());

        t2.Draw();
        Console.WriteLine(t2.GetId());

        //Console.WriteLine(t.GetId());
    }
}