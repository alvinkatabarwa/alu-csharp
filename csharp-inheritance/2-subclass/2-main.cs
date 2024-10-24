using System;

class Program
{
    static void Main(string[] args)
    {
        // Check if Dog is a subclass of Animal
        if (Obj.IsOnlyASubclass(typeof(Dog), typeof(Animal)))
            Console.WriteLine("Dog is a subclass of Animal");
        else
            Console.WriteLine("Dog is not a subclass of Animal");

        // Check if Cat is a subclass of Animal
        if (Obj.IsOnlyASubclass(typeof(Cat), typeof(Animal)))
            Console.WriteLine("Cat is a subclass of Animal");
        else
            Console.WriteLine("Cat is not a subclass of Animal");

        // Check if Cat is a subclass of Dog
        if (Obj.IsOnlyASubclass(typeof(Cat), typeof(Dog)))
            Console.WriteLine("Cat is a subclass of Dog");
        else
            Console.WriteLine("Cat is not a subclass of Dog");

        // Check if Animal is a subclass of Animal
        if (Obj.IsOnlyASubclass(typeof(Animal), typeof(Animal)))
            Console.WriteLine("Animal is a subclass of Animal");
        else
            Console.WriteLine("Animal is not a subclass of Animal");
    }
}

// Define base class Animal
class Animal
{
    // Empty class
}

// Define derived class Dog
class Dog : Animal
{
    // Empty class
}

// Define derived class Cat
class Cat : Animal
{
    // Empty class
}
