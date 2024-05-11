using System;

public interface ISwimmable
{
    void Swim();
}

public interface IFlyable
{
    int MaxHeight { get; }
    void Fly();
}

public interface IRunnable
{
    int MaxSpeed { get; }
    void Run();
}

public interface IAnimal
{
    int LifeDuration { get; }
    void Voice();
    void ShowInfo();
}

public class Cat : IAnimal, IRunnable
{
    public int LifeDuration { get; } = 15; 
    public int MaxSpeed { get; } = 30; 

    public void Voice()
    {
        Console.WriteLine("Meow!");
    }

    public void Run()
    {
        Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"I am a Cat and I live approximately {LifeDuration} years.");
    }
}

public class Eagle : IAnimal, IFlyable
{
    public int LifeDuration { get; } = 25; 
    public int MaxHeight { get; } = 5000; 

    public void Voice()
    {
        Console.WriteLine("No voice!");
    }

    public void Fly()
    {
        Console.WriteLine($"I can fly at {MaxHeight} meters height!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"I am an Eagle and I live approximately {LifeDuration} years.");
    }
}

public class Shark : IAnimal, ISwimmable
{
    public int LifeDuration { get; } = 30; 

    public void Voice()
    {
        Console.WriteLine("No voice!");
    }

    public void Swim()
    {
        Console.WriteLine("I can swim!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"I am a Shark and I live approximately {LifeDuration} years.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage:

        Cat cat = new Cat();
        cat.ShowInfo(); 
        cat.Voice();    
        cat.Run();      

        Console.WriteLine();

        Eagle eagle = new Eagle();
        eagle.ShowInfo(); 
        eagle.Voice();    
        eagle.Fly();      

        Console.WriteLine();

        Shark shark = new Shark();
        shark.ShowInfo(); 
        shark.Voice();    
        shark.Swim();     
    }
}
