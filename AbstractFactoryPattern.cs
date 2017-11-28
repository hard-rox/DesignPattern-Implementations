// This is implimetation of
// AbstractFactory Design Pattern
// As an assignment

// Submitted to:
// Lutfun Nahar Lota
//      Lecturer
//    Dept. Of CSE

// Submitted By:
// Md. Rasedur Rahman
// ID: 13142103016, Intake:26(2)
// Dept. Of CSE



using System;

interface IHouse
{
    void Draw();
}

interface IColor
{
    void FillColor();
}

class CityHouse:IHouse
{
    public void Draw()
    {
        Console.WriteLine("CityHouse Drawn.");
    }
}

class VillageHouse:IHouse
{
    public void Draw()
    {
        Console.WriteLine("VillageHouse Drawn.");
    }
}

class HouseFactory
{
    public IHouse GetHouse(string houseType)
    {
        if(houseType=="City")
            return new CityHouse();
        else if(houseType=="Village")
            return new VillageHouse();
        else
            throw new ArgumentException ("Invalid house type","houseType");
    }
}

class Red:IColor
{
    public void FillColor()
    {
        Console.WriteLine("Red colored.");
    }
}

class Blue:IColor
{
    public void FillColor()
    {
        Console.WriteLine("Blue colored.");
    }
}

class ColorFactory
{
    public IColor GetColor(string colorName)
    {
        if(colorName=="Red")
            return new Red();
        else if(colorName=="Blue")
            return new Blue();
        else
            throw new ArgumentException("Invalid color name","colorName");
    }
}

class AbstractFactory
{
    public HouseFactory GetHouseFactory()
    {
        return new HouseFactory();
    }
    public ColorFactory GetColorFactory()
    {
        return new ColorFactory();
    }
}

class MainClass
{
    public static void Main()
    {
        AbstractFactory af=new AbstractFactory();
        af.GetHouseFactory().GetHouse("City").Draw();
        af.GetColorFactory().GetColor("Red").FillColor();
    }
}