using System;

class MyProgram  // Renamed class
{
    static void Main(string[] args)
    {
        int[] array = { 0, 1, 2, 3, 4 };

        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Array Length: " + array.Length);
    }
}
