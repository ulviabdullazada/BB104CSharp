using System.Reflection.Emit;
using System.Threading.Channels;

namespace Polimorphism;
//1. Abstract classlar instance almaq olmayan classlardir.
//2. Yalniz abstract class daxilinde abstract methodlar yazmaq olur.
abstract class Animal
{
    // Body-si olmayan method abstract method adlanir
    public abstract void Eat();
    public void Eat2()
    {
        Console.WriteLine("Eat as animal");
    }
}
abstract class Bird : Animal
{
    //public abstract void Fly();
    public virtual void Fly()
    {
        Console.WriteLine("flapping wings");
    }
}
abstract class Fish : Animal, ISwim
{
    public abstract void Swim();
}
class Shark : Fish
{
    public override void Eat()
    {
        Console.WriteLine("Shark eating small fish");
    }
    public void Eat2()
    {
        Console.WriteLine("Shark eating small fish");
    }
    public override void Swim()
    {
        Console.WriteLine("Swim as Shark");
    }
}
class Parrot : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Parrot eating wheat");
    }
    public void Eat2()
    {
        Console.WriteLine("Parrot eating wheat");
    }
    //public override void Fly()
    //{
    //    Console.WriteLine("Fly as parrot");
    //}

}
class Penguin : Bird, ISwim
{
    public override void Fly()
    {
        Console.WriteLine("=(((((");
    }
    public override void Eat()
    {
        Console.WriteLine("Eating little fish");
    }

    public void Swim()
    {
        Console.WriteLine("Swim as penguin");
    }
}
class Owl : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Owl eating worms");
    }
}
abstract class Domestic : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Eat fodder");
    }
}
class Cat : Domestic
{
    
}
class Dog : Domestic, ISwim
{
    public void Swim()
    {
        Console.WriteLine("Swim as dog");
    }
}

class Sheep : Domestic
{
    public override void Eat()
    {
        base.Eat();
        Random random = new Random();
        int result = random.Next(2, 4);
        if (result == 3)
        {
            Console.WriteLine("Eating wild grass");
        }
    }
}