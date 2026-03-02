using System;

/// <summary>
/// Represents a geometric shape.
/// </summary>
public class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Represents a rectangle, which is a shape.
/// </summary>
public class Rectangle : Shape
{
    protected int width;
    protected int height;

    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    public new int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

/// <summary>
/// Represents a square, which is a rectangle.
/// </summary>
public class Square : Rectangle
{
    private int size;

    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            Width = value;
            Height = value;
        }
    }

    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}