using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items
        Console.WriteLine("Number of items: " + aStack.Count);

        // Print the top item or "Stack is empty"
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }

        // Check if stack contains search item
        bool contains = aStack.Contains(search);
        Console.WriteLine("Stack contains \"" + search + "\": " + contains);

        // If contains, remove all items up to and including search
        if (contains)
        {
            while (aStack.Pop() != search)
            {
                // Keep popping until we find and remove search
            }
        }

        // Add the new item
        aStack.Push(newItem);

        return aStack;
    }
}