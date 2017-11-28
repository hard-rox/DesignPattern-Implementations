using System;

public interface IPlay
{
    void PlayToday();
}

public class Student
{
    public void Play(IPlay day)
    {
        day.PlayToday();
    }
}

public class Saturday:IPlay
{
    public void PlayToday()
    {
        Console.WriteLine("Saturday Play.");
    }
}

public class Sunday:IPlay
{
    public void PlayToday()
    {
        Console.WriteLine("Sunday Play.");
    }
}

public class Monday:IPlay
{
    public void PlayToday()
    {
        Console.WriteLine("Monday Play.");
    }
}

public class Tuesday:IPlay
{
    public void PlayToday()
    {
        Console.WriteLine("Tuesday Play.");
    }
}

public class Wednesday:IPlay
{
    public void PlayToday()
    {
        Console.WriteLine("Wednesday Play.");
    }
}

public class Thursday:IPlay
{
    public void PlayToday()
    {
        Console.WriteLine("Thursday Play.");
    }
}

public class Friday:IPlay
{
    public void PlayToday()
    {
        Console.WriteLine("Only Ghum is Real.");
    }
}

public class MainClass
{
    public static void Main()
    {
        Student student=new Student();
        student.Play(new Saturday());
        student.Play(new Sunday());
        student.Play(new Monday());
        student.Play(new Tuesday());
        student.Play(new Wednesday());
        student.Play(new Thursday());
        student.Play(new Friday());

        Console.ReadKey();
    }
}