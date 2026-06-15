using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
class Queue<T>
{
    /// <summary>
    /// Checks the type of the queue.
    /// </summary>
    /// <returns>The type of T.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
