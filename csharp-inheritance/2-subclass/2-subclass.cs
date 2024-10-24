using System;

public class Obj
{
    // Method that checks if the derivedType is a subclass of baseType
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        // Check if derivedType is a subclass of baseType
        return derivedType.IsSubclassOf(baseType);
    }
}
