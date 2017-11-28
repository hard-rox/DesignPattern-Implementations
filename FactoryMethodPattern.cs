using System;

interface IHouse
{
    void Draw();
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
            throw new System.ArgumentException("Invalid house type","houseType");
    }
}

class MainClass
{
    public static void Main()
    {
        HouseFactory HF=new HouseFactory();
        HF.GetHouse("City").Draw();
        HF.GetHouse("Village").Draw();
        //HF.GetHouse("Other").Draw();
    }
}