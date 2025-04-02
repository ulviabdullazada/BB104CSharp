namespace Polimorphism;
internal class Program
{
    static void Main(string[] args)
    {
        //Animal a = new Animal();
        //Animal murad = new Shark();
        //Bird nurlan = new Parrot();
        //Bird gumush = new Penguin();
        //Bird aytan = new Owl();
        //Bird[] birds = [nurlan, gumush, aytan];
        //foreach (var bird in birds)
        //{
        //    bird.Fly();
        //}
        //murad.Eat();
        //nurlan.Eat();
        //Domestic[] domestics =
        //{
        //    new Cat(),
        //    new Dog(),
        //    new Sheep()
        //};
        //foreach (Domestic dom in domestics)
        //{
        //    dom.Eat();
        //}
        ISwim[] animals = [new Shark(), new Dog(), new Penguin()];
        foreach (ISwim animal in animals)
        {
            animal.Swim();
        }
        ISwim spike = new Dog();
        spike.Test();
    }
}
