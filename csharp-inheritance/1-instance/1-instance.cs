// 1-instance.cs
public class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        // Checks if obj is an instance of Array or a derived type
        return obj is Array;
    }
}
