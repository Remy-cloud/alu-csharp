#nullable disable
using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0 || n <= myLList.First.Value)
        {
            return myLList.AddFirst(n);
        }

        LinkedListNode<int> current = myLList.First;

        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }

        return myLList.AddAfter(current, n);
    }
}