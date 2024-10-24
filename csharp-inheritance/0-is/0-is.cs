public class Obj
{
    // this method if checks if the object is an int
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int; // this returns true if obj is of type int, otherwise false
    }
}
