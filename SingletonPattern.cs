using System;

public class SingleModel
{
    private static SingleModel Instance=new SingleModel();

    private SingleModel(){}

    public static SingleModel GetInstance()
    {
        return Instance;
    }
    public void Message()
    {
        Console.WriteLine("Hello. Are u Single?");
        Console.WriteLine("Yes.");
    }
}

public class SingletoDemo
{
    public static void Main()
    {
        SingleModel single=SingleModel.GetInstance();
        single.Message();

        SingleModel single2=SingleModel.GetInstance();
        single2.Message();
    }
}