/// <summary>
/// Provides object type checking operations.
/// </summary>
public class Obj
{
    /// <summary>
    /// Returns True if the object is an instance of Array or a subclass, otherwise returns False.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if obj is an instance of Array or a subclass, otherwise False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}