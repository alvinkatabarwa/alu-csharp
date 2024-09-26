using System;

public class Line
{
    
    public static void PrintLine(int length)
    {
        
        if (length > 0)
        {
            // Print the underscore character 'length' times
            for (int i = 0; i < length; i++)
            {
                Console.Write('_');
            }
        }
        
        Console.WriteLine();
    }
    public static void Main()
    {
        // Test cases
        PrintLine(5);    // Output: _____
        PrintLine(0);    // Output: (newline)
        PrintLine(-3);   // Output: (newline)
        PrintLine(10);   // Output: ________ 
    }
}