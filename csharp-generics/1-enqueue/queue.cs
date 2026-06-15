using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
class Queue<T>
{
    public class Node
    {
        /// <summary>
        /// The value of the node.
        /// </summary>
        public T? value;

        /// <summary>
        /// The next node in the queue.
        /// </summary>
        public Node? next = null;

        /// <summary>
        /// Constructor for the node.
        /// </summary>
        /// <param name="val">The value of the node.</param>
        public Node(T val)
        {
            value = val;
        }
    }

    private Node? head;
    private Node? tail;
    private int count;

    /// <summary>
    /// Checks the type of the queue.
    /// </summary>
    /// <returns>The type of T.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Adds a new node to the end of the queue.
    /// </summary>
    /// <param name="value">The value to add.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns>The number of nodes.</returns>
    public int Count()
    {
        return count;
    }
}
