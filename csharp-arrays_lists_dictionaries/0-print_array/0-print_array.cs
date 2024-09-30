using System;

class Array
{
    // create and print an array of integers based on the provided size
    public static int?[] CreatePrint(int size)
    {
        // Check if size is less than 0, print error message and return null
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        // Create an array of integers with the given size
        int?[] array = new int?[size];

        // If size is 0, just return the array and print a blank line
        if (size == 0)
        {
            Console.WriteLine();
            return array;
        }

        // Fill the array with numbers starting from 0 and print them
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
            Console.Write($"{i}");

          
            if (i < size - 1)
            {
                Console.Write(" ");
            }
        }

      
        Console.WriteLine();
        
        return array;
    }
}
