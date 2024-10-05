using System;
using System.Collections.Generic; // Correct namespace

class ListOperations // Changed class name to avoid conflict with built-in List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        int div = 0;

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                div = list1[i] / list2[i];
                result.Add(div);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0); // Handle division by zero by adding 0 to result
            }
        }

        return result;
    }
}
