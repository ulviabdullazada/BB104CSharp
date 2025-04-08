namespace Casting
{
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
    abstract class Fish : Animal
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
    class Penguin : Bird
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
        public int A { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Owl eating worms");
        }
    }
}
