using System;
using System.Collections.Generic;

public class ListOperations
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                if (i >= list1.Count || i >= list2.Count)
                {
                    throw new IndexOutOfRangeException("Out of range");
                }

                if (list2[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
                else
                {
                    result.Add(list1[i] / list2[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                result.Add(0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
        }

        return result;
    }
}
