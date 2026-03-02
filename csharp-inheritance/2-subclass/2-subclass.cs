using System;

/// <summary>
/// Provides object type checking operations.
/// </summary>
public class Obj
{
    /// <summary>
    /// Returns True if derivedType is a subclass of baseType, but not the baseType itself.
    /// </summary>
    /// <param name="derivedType">The type to check.</param>
    /// <param name="baseType">The base type to check against.</param>
    /// <returns>True if derivedType is a subclass of baseType, otherwise False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType != baseType && derivedType.IsSubclassOf(baseType);
    }
}