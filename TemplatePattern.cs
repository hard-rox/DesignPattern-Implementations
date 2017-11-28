using System;

public abstract class Student
{
    public abstract void WakeUp();
    public abstract void Breakfast();
    public abstract void GotoSchool();
    public abstract void BackFromSchool();
    public abstract void Play();
    public abstract void Eat();
    public abstract void Sleep();

    public void TemplateMethod()
    {
        WakeUp();
        Breakfast();
        GotoSchool();
        BackFromSchool();
        Play();
        Eat();
        Sleep();

        Console.WriteLine("Template Executed.");
    }
}

public class SchoolStudent:Student
{
    public override void WakeUp()
    {
        Console.WriteLine("School Student Wakeup.");
    }
    public override void Breakfast()
    {
        Console.WriteLine("School Student Breakfast.");
    }
    public override void GotoSchool()
    {
        Console.WriteLine("School Student Goto School.");
    }
    public override void BackFromSchool()
    {
        Console.WriteLine("School Student Back from School.");
    }
    public override void Play()
    {
        Console.WriteLine("School Student Play.");
    }
    public override void Eat()
    {
        Console.WriteLine("School Student Eat.");
    }
    public override void Sleep()
    {
        Console.WriteLine("School Student Sleep.");
    }
}

public class CollegeStudent:Student
{
    public override void WakeUp()
    {
        Console.WriteLine("College Student Wakeup.");
    }
    public override void Breakfast()
    {
        Console.WriteLine("College Student Breakfast.");
    }
    public override void GotoSchool()
    {
        Console.WriteLine("College Student Goto School.");
    }
    public override void BackFromSchool()
    {
        Console.WriteLine("College Student Back from College.");
    }
    public override void Play()
    {
        Console.WriteLine("College Student Play.");
    }
    public override void Eat()
    {
        Console.WriteLine("College Student Eat.");
    }
    public override void Sleep()
    {
        Console.WriteLine("College Student Sleep.");
    }
}

class MainClass
{
    public static void Main()
    {
        SchoolStudent schoolStudent=new SchoolStudent();
        CollegeStudent collegeStudent=new CollegeStudent();

        schoolStudent.TemplateMethod();
        collegeStudent.TemplateMethod();

        Console.ReadKey();
    }   
}