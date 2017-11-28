using System;
using System.Collections;
using System.Collections.Generic;

public interface IShape
{
    IShape [] Draw();
    void Show();
}

public class Line:IShape
{
    public Line(int px1, int py1, int px2, int py2)
    {

    }

    public IShape[] Draw()
    {
        IShape [] ShapePaths={this};
        return ShapePaths;
    }

    public void Show()
    {
        Console.WriteLine("Line Drawn.");
    }
}

public class Ractangle:IShape
{
    IShape [] RactangleEdges={new Line(1,2,3,4), new Line(1,2,3,4), new Line(1,2,3,4), new Line(1,2,3,4),};
    public IShape[] Draw()
    {
        return RactangleEdges;
    }

    public void Show()
    {
        Console.WriteLine("Ractangle Drawn.");
        foreach (IShape item in RactangleEdges)
        {
            item.Show();
        }
    }
}

class Complex:IShape
{
    //ArrayList ShapeList=new ArrayList();
    List<IShape> ShapeList=new List<IShape>();
    public void AddToShape(IShape aShape)
    {
        ShapeList.Add(aShape);
    }

    public IShape [] Draw()
    {
        return ShapeList.ToArray();
    }

    public void Show()
    {
        Console.WriteLine("Complex Drawn.");
        foreach (var item in ShapeList)
        {
            item.Show();
        }
    }
}

public class MainClass
{
    public static void Main()
    {
        IShape LineShape=new Line(1,2,3,4);
        IShape RactangleShape=new Ractangle();
        Complex complexShape=new Complex();
        complexShape.AddToShape(LineShape);
        complexShape.AddToShape(RactangleShape);

        LineShape.Show();
        RactangleShape.Show();
        complexShape.Show();
    }    
}