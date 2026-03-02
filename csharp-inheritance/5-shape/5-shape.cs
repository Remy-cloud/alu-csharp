using System;

/// <summary>
/// Represents a geometric shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Returns the area of the shape. Not implemented in base class.
    /// </summary>
    /// <returns>The area of the shape.</returns>
    /// <exception cref="NotImplementedException">Thrown always in base class.</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}