/// <summary>
/// Provides object type checking operations.
/// </summary>
public class Obj
{
    /// <summary>
    /// Returns True if the object is an int, otherwise returns False.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if obj is int, otherwise False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}