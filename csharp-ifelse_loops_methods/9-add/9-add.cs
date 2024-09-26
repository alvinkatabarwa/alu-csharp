using System;

public class Number
{

    public static int Add(int a, int b)
    {
        
        return a + b;
    }

    
    public static void Main()
    {
        // Test cases
        Console.WriteLine(Add(5, 3));   // Output: 8
        Console.WriteLine(Add(-1, 1));  // Output: 0
        Console.WriteLine(Add(0, 0));   // Output: 0
        Console.WriteLine(Add(123, 456)); // Output: 579
    }
}