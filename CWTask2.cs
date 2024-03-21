using System;

abstract class Animal
{
    public string name{ get; set; }
    public string type{ get; set; }
    public abstract void MakeSound();
    public virtual void info()
    {
        Console.WriteLine($"Название: \n{name}" );
        Console.WriteLine("Звук:");
        MakeSound();
    }
}
class Giraffe : Animal
{
    public Giraffe()
    {
        name = "Giraffe";
        type = "Не знаю";
    }

    public override void MakeSound()
    {
        Console.WriteLine("ououuo");
    }
}
class Pig : Animal
{
    public Pig()
    {
        name = "Pig";
        type = "Травоядный";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Hru-hru");
    }
}
class Elephant : Animal
{
    public Elephant()
    {
        name = "Elephant";
        type = "Не знаю";
    }

    public override void MakeSound()
    {
        Console.WriteLine("UUUUuu");
    }
}
class Lion : Animal
{
    public Lion()
    {
        name = "Lion";
        type = "Хищник";
    }

    public override void MakeSound()
    {
        Console.WriteLine("RRaRaRrarrr");
    }
}
class Tiger: Animal
{
    public Tiger()
    {
        name = "Tiger";
        type = "Хищник";
    }

    public override void MakeSound()
    {
        Console.WriteLine("RRRRRRRRR");
    }
}
class Monkey: Animal
{
    public Monkey()
    {
        name = "Monkey";
        type = "Травоядный";
    }

    public override void MakeSound()
    {
        Console.WriteLine("ehehhehhe");
    }
}
class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Giraffe(), new Pig(), new Lion(),
            new Pig(), new Giraffe(), new Tiger(),
            new Lion(), new Giraffe(), new Monkey(),
            new Tiger(), new Elephant(), new Tiger(),
            new Elephant(), new Tiger(), new Monkey()
        };
        
        Console.WriteLine("Травоядный:");
        foreach (var animal in animals)
        {
            if (animal.type == "Травоядный")
            {
                animal.info();
            }
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Хищник:");
        foreach (var animal in animals)
        {
            if (animal.type == "Хищник")
            {
                animal.info();
            }
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Не знаю:");
        foreach (var animal in animals)
        {
            if (animal.type == "Не знаю")
            {
                animal.info();
            }
        }
    }
}