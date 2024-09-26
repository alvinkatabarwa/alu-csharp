using System;

class Character
{
    // Method that checks if a character is lowercase
    public static bool IsLower(char c)
    {
        // Check if the character is between 'a' and 'z' in ASCII values
        if (c >= 'a' && c <= 'z')
        {
            return true; // It's a lowercase letter
        }
        else
        {
            return false; // It's not a lowercase letter
        }
    }
}

class Program
{
    // The static Main method: the entry point for the program
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g' };

        // Loop through each character in the letters array
        for (int i = 0; i < letters.Length; i++)
        {
            // Check if the character is lowercase using the IsLower method
            if (Character.IsLower(letters[i]))
            {
                Console.WriteLine($"{letters[i]} is lowercase");
            }
            else
            {
                Console.WriteLine($"{letters[i]} is uppercase");
            }
        }
    }
}
