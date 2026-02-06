using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items
        Console.WriteLine("Number of items: " + aQueue.Count);

        // Print the first item or "Queue is empty"
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: " + aQueue.Peek());
        }

        // Add the new item
        aQueue.Enqueue(newItem);

        // Check if queue contains search item
        bool contains = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"" + search + "\": " + contains);

        // If contains, remove all items up to and including search
        if (contains)
        {
            while (aQueue.Dequeue() != search)
            {
                // Keep dequeuing until we find and remove search
            }
        }

        return aQueue;
    }
}