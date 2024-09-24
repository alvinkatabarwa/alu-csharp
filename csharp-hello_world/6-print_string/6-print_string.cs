using System;

class Program
{
    static void Main(string[]args)
    {
        string str = "Holberton School";
        Console.WriteLine(str + str + str);  // Print str three times
        Console.WriteLine(str.Substring(0, 9)); // Print the first 9 characters

    }
}